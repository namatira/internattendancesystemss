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
    public class EditInternAttendanceModel : PageModel
    {
        private ApplicationDbContext _db;

        public EditInternAttendanceModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Attendance Attendance { get; set; }

        public async Task OnGetAsync(int id)
        {
            Attendance = await _db.Attendance
                .Select(a => new Attendance { 
                    Id = a.Id,
                    Date = a.Date,
                    Time = a.Time,
                    Status = a.Status,
                    UserId = a.UserId,
                    Username = a.User.Username,
                })
                .FirstOrDefaultAsync(u => u.Id == id);
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var AttendanceFromDb = await _db.Attendance.FindAsync(Attendance.Id);

                AttendanceFromDb.Status = Attendance.Status;
                await _db.SaveChangesAsync();

                return RedirectToPage("InternAttendance");
            }
            else
            {
                return Page();
            }
            
        }
    }
}