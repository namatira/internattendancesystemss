using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AttendanceSytstemWebApplication.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace AttendanceSytstemWebApplication.Pages.AmbaDashboard
{
    public class ScheduleModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public ScheduleModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public IEnumerable<Schedule> Schedules { get; set; }    

        public async Task OnGetAsync()
        {
            int id;
            var ID = Int32.TryParse(HttpContext.User.Claims.FirstOrDefault(c => c.Type == "User_ID").Value, out id);
            Schedules = await _db.Schedule
                .Where(a => a.UserId == id)
                .Where(a => (a.Date == DateTime.Now.Date && a.EndTime >= DateTime.Now ) || a.Date > DateTime.Now.Date)
                .OrderBy(a => a.Date)
                .ToListAsync();


        }
    }
}