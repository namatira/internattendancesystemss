using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AttendanceSytstemWebApplication.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AttendanceSytstemWebApplication.Pages.AmbaDashboard
{
    public class InternAttendanceModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public InternAttendanceModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet()
        {

        }
    }
}