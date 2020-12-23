using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AttendanceSytstemWebApplication.Model;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace AttendanceSytstemWebApplication.Pages
{
    [AllowAnonymous]
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public new User User { get; set; }

        public void OnGet()
        {
        }


        //LoginSystem using Cookies Authentication
        public async Task<IActionResult> OnPost()
        {
            var acc = Login(User.Username, User.Password);
            if (acc == null)
            {
                ModelState.AddModelError(string.Empty, "Invalid Login Attempt");
                return Page();
            }
            else
            {
                if (acc.Role.Equals(1))
                {
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, User.Username),
                        new Claim("User_ID", acc.Id.ToString())
                    };
                    var claimsIdentify = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    var authProperties = new AuthenticationProperties
                    {

                    };

                    await HttpContext.SignInAsync(
                        CookieAuthenticationDefaults.AuthenticationScheme, 
                        new ClaimsPrincipal(claimsIdentify),
                        authProperties);
                    return RedirectToPage("/AmbaDashboard/Index");

                }
                else if (acc.Role.Equals(2))
                {
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, User.Username),
                        new Claim("User_ID", acc.Id.ToString())
                    };
                    var claimsIdentify = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    var authProperties = new AuthenticationProperties
                    {

                    };

                    await HttpContext.SignInAsync(
                        CookieAuthenticationDefaults.AuthenticationScheme,
                        new ClaimsPrincipal(claimsIdentify),
                        authProperties);
                    return RedirectToPage("/InternDashboard/Index");
                }
                else
                {
                    return Page();
                }

            }
        }

        public async Task<IActionResult> OnGetLogout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToPage("/Index");
        }
        
        //Pure Session LoginSystem
        
        /*public IActionResult OnGetLogout()
        {
            HttpContext.Session.Remove("Amba_Id");
            HttpContext.Session.Remove("Amba_Username");
            HttpContext.Session.Clear();
            return RedirectToPage("/Index");
        }

        public IActionResult OnPost()
        {
            var acc = Login(User.Username, User.Password);
            if (acc == null)
            {
                return Page();
            }
            else
            {
                if (acc.Role.Equals(1))
                {
                    HttpContext.Session.SetInt32("Amba_Id", acc.Id);
                    HttpContext.Session.SetString("Amba_Username", acc.Username);
                    return RedirectToPage("/AmbaDashboard/Index");
                }
                else if (acc.Role.Equals(2))
                {
                    HttpContext.Session.SetInt32("Intern_Id", acc.Id);
                    HttpContext.Session.SetString("Intern_Username", acc.Username);
                    return RedirectToPage("/InternDashboard/Index");
                }
                else
                {
                    return Page();
                }
                
            }
        }*/

        private User Login(string username, string password)
        {
            var account = _db.User.SingleOrDefault(a => a.Username.Equals(username));
            if (account != null)
            {
                if(account.Password.Equals(password))
                {
                    return account;
                }
            }
            return null;
        }
    }
}
