using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AttendanceSytstemWebApplication.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AttendanceSytstemWebApplication.Controllers
{
    [Route("api/Schedule")]
    [ApiController]
    public class AmbaScheduleController : Controller
    {
        private ApplicationDbContext _db;

        public AmbaScheduleController(ApplicationDbContext db)
        {
            _db = db;
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var scheduleFromDb = await _db.Schedule.FirstOrDefaultAsync(u => u.Id == id);
            if (scheduleFromDb == null)
            {
                return Json(new { success = false, message = "Error while Deleting" });
            }
            _db.Schedule.Remove(scheduleFromDb);
            await _db.SaveChangesAsync();
            return Json(new { success = true, message = "Delete successful" });
        }
    }
}