using LitLounge.Constants;
using LitLounge.Helpers;
using LitLounge.Models;
using LitLounge.ViewModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using System.Text;

namespace LitLounge.Controllers
{
    public class AccountController : Controller
    {
        private DataContext context;
        public AccountController(DataContext context)
        {
            this.context = context;
        }

        [HttpGet]
        [Route("~/Login")]
        [Route("~/Account/Login")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                string password = Encrypter.Encrypt(model.Password);
                User user = await context.Users.FirstOrDefaultAsync(x => x.Email == model.Email && x.Password == password);
                if (user != null)
                {
                    await Authenticate(user);

                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("", "Incorrect login and (or) password");
            }
            return View(model);
        }

        [HttpGet]
        [Route("~/Register")]
        [Route("~/Account/Register")]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            User user = await context.Users.FirstOrDefaultAsync(x => x.Email == model.Email);
            if (user != null)
            {
                ModelState.AddModelError("Email", "User with this email already exists");
                return View(model);
            }
            user = new User()
            {
                Email = model.Email,
                Password = Encrypter.Encrypt(model.Password),
                Role = UserRoleNames.User
            };
            context.Users.Add(user);
            context.SaveChanges();
            await Authenticate(user);
            return RedirectToAction("Index", "Home");
        }

        private async Task Authenticate(User user)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, user.Email),
                new Claim(ClaimsIdentity.DefaultRoleClaimType, user.Role)
            };

            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", 
                ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }

        [Route("~/Logout")]
        private async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Account");
        }
    }
}
