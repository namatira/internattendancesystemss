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
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public IEnumerable<Attendance> Attendance { get; set; }
        public async Task OnGetAsync()
        {
            Attendance = await _db.Attendance
                .Select(a => new Attendance
                {
                    Id = a.Id,
                    Time = a.Time,
                    Date = a.Date,
                    Status = a.Status,
                    UserId = a.UserId,
                    Username = a.User.Username,

                })
                .Where(b => b.Date == DateTime.Now.Date)
                .ToListAsync();
        }
    }
}