using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AttendanceSytstemWebApplication.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace AttendanceSytstemWebApplication.Pages.AmbaDashboard
{
    public class UpsertScheduleModel : PageModel
    {
        private ApplicationDbContext _db;

        public UpsertScheduleModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Schedule Schedule { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            Schedule = new Schedule();
            if (id == null)
            {
                //create 
                Schedule.Date = DateTime.Now.Date;
                return Page();
            }
            Schedule = await _db.Schedule.FirstOrDefaultAsync(u => u.Id == id);
            if (Schedule == null)
            {
                //Edit + update
                return NotFound();
            }

            return Page();
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid && Schedule.Date >= DateTime.Now.Date && Schedule.EndTime >= Schedule.StartTime)
            {
                if ((Schedule.Date == DateTime.Now.Date && Schedule.StartTime >= DateTime.Now) || Schedule.Date != DateTime.Now.Date)
                {
                    if (Schedule.Id == 0 )
                    {
                        _db.Schedule.Add(Schedule);
                    }
                    else
                    {
                        var ScheduleFromDb = await _db.Schedule.FindAsync(Schedule.Id);

                        ScheduleFromDb.Date = Schedule.Date;
                        ScheduleFromDb.StartTime = Schedule.StartTime;
                        ScheduleFromDb.EndTime = Schedule.EndTime;
                    }

                    await _db.SaveChangesAsync();

                    return RedirectToPage("Schedule");
                }
                return Page();

            }
            return Page();
        }
    }
}