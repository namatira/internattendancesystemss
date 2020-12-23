using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AttendanceSytstemWebApplication.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AttendanceSytstemWebApplication.Controllers
{
    [Route("api/AmbassadorInternSchedule")]
    [ApiController]
    public class AmbaInternAttendanceController : Controller
    {
        private readonly ApplicationDbContext _db;

        public AmbaInternAttendanceController(ApplicationDbContext db)
        {
            _db = db;
        }
        [BindProperty]
        public Attendance Attendance { get; set; }
        public async Task<IActionResult> GetAll()
        {
            return Json(new
            {
                data = await _db.Attendance
                .Select(a => new Attendance
                {
                    Id = a.Id,
                    Date = a.Date,
                    Time = a.Time,
                    Status = a.Status,
                    UserId = a.UserId,
                    Username = a.User.Username,
                    Role = a.User.Role
                })
                .Where(b => b.Role == 2)
                .ToListAsync()
            });
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var attendanceFromDb = await _db.Attendance.FirstOrDefaultAsync(u => u.Id == id);
            if (attendanceFromDb == null)
            {
                return Json(new { success = false, message = "Error while Deleting" });
            }
            _db.Attendance.Remove(attendanceFromDb);
            await _db.SaveChangesAsync();
            return Json(new { success = true, message = "Delete successful" });
        }

    }
}