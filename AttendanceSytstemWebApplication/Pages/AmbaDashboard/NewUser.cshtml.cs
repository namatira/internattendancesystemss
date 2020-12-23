using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AttendanceSytstemWebApplication.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AttendanceSytstemWebApplication.Pages.AmbaDashboard
{
    public class NewUserModel : PageModel
    {
        private ApplicationDbContext _db;

        public NewUserModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public User Users { get; set; }

        public void OnGet()
        {
                
        }

        public async Task<IActionResult> OnPost()
        {
            Users.Password = Users.Username;
            _db.User.Add(Users);
            await _db.SaveChangesAsync();
            return RedirectToPage("Index");

        }
    }
}