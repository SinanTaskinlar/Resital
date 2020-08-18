using System;
using System.Threading.Tasks;
using BLL.Abstract;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Web.Identity;
using Web.Models;

namespace Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly ICartService _cartService;
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager,
            ICartService cartService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _cartService = cartService;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (!ModelState.IsValid) return View(model);

            var a = await _userManager.FindByEmailAsync(model.Email);

            var res = await _signInManager.PasswordSignInAsync(a, model.Password, true, true);

            if (res.Succeeded) return Redirect("~/");

            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            if (!ModelState.IsValid) return View(model);

            var a = new User
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                UserName = model.UserName,
                Email = model.Email
            };

            var res = await _userManager.CreateAsync(a, model.Password);
            if (res.Succeeded)
            {
                _cartService.InitCart(Guid.Parse(a.Id));
                //var tok = await _userManager.GenerateEmailConfirmationTokenAsync(a);

                //_ = Url.Action("ConfirmEmail", "Account", new
                //{
                //    userId = a.UserName,
                //    token = tok
                //});

                return RedirectToAction("Login");
            }

            ModelState.AddModelError("Password", "Şifre hatası");
            return View(model);
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return Redirect("~/");
        }

        public async Task<IActionResult> ConfirmEmail(string userId, string token)
        {
            var user = await _userManager.FindByIdAsync(userId);
            var res = await _userManager.ConfirmEmailAsync(user, token);
            if (res.Succeeded)
            {
                TempData["message"] = "Hesap Onaylandı";
                return View();
            }

            return View();
        }
    }
}