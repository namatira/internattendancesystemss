using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AttendanceSytstemWebApplication.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AttendanceSytstemWebApplication.Pages.AmbaDashboard
{
    public class NewAttendanceModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public NewAttendanceModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Attendance Attendance { get; set; }
        public void OnGet()
        {
            Attendance = new Attendance
            {
                Date = DateTime.Now.Date,
                Time = DateTime.Now
            };
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                _db.Attendance.Add(Attendance);
                await _db.SaveChangesAsync();
            }
            return Page();
        }
    }
}