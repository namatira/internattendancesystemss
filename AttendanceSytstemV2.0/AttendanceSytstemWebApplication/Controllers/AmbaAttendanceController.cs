using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AttendanceSytstemWebApplication.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AttendanceSytstemWebApplication.Controllers
{
    [Route("api/Ambassador")]
    [ApiController]
    public class AmbaAttendanceController : Controller
    {
        private readonly ApplicationDbContext _db;

        public AmbaAttendanceController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            int id;
            var ID = Int32.TryParse(HttpContext.User.Claims.FirstOrDefault(c => c.Type == "User_ID").Value, out id);
            if (ID)
            {
                return Json(new
                {
                    data = await _db.Attendance.Where(b => b.UserId == id).ToListAsync()
                });
            }
            return null;
        }
    }
}