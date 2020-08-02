using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Resital.Model;
using Web.Identity;
using Web.Models;

namespace Web.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<User> _userManager;
        private SignInManager<User> _signInManager;

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager )
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var a = await _userManager.FindByEmailAsync(model.Email);

            var res = await _signInManager.PasswordSignInAsync(a, model.Password,true,true);

            if (res.Succeeded)
            {
                //TODO: return RedirectToRoute()
            }

            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var a = new User
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                UserName = model.Username,
                Email = model.Email
            };

            var res = await _userManager.CreateAsync(a, model.Password);
            if (res.Succeeded)
            {
                return RedirectToAction("Login");
            }

            ModelState.AddModelError("Password","Şifre hatası");
            return View(model);
        }
    }
}
