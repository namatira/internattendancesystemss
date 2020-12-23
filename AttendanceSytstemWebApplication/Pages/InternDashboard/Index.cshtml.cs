using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AttendanceSytstemWebApplication.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace AttendanceSytstemWebApplication.Pages.InternDashboard
{ 
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public IEnumerable<Attendance> Intern { get; set; }
        public async Task OnGet()
        {
            Intern = await _db.Attendance.ToListAsync(); //extraction //asynch will let you run multiple task at a time
        }
    }
}