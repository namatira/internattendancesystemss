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
    [Route("api/Notification")]
    [ApiController]
    public class NotificationController : Controller
    {
        private readonly ApplicationDbContext _db;

        public NotificationController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<JsonResult> GetNotif()
        {
            
            return new JsonResult(new
            {
                data = await _db.Attendance
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
                .OrderByDescending(b => b.Time)
                .ToListAsync()
            });
        }
    }
}