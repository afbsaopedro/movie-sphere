using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MovieSphere.Data;
using MovieSphere.Models;
using System.Runtime.CompilerServices;

namespace MovieSphere.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ApplicationDbContext _context;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, ApplicationDbContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
        }

        public IActionResult Login()
        {
            var response = new LoginVM();
            return View(response);
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginVM login)
        {
            if (!ModelState.IsValid) return View(login);

            var user = await _userManager.FindByEmailAsync(login.EmailAddress);

            if (user != null)
            {
                var passwordCheck = await _userManager.CheckPasswordAsync(user, login.Password);

                if (passwordCheck)
                {
                    var result = await _signInManager.PasswordSignInAsync(user, login.Password, false, false);

                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
                TempData["Error"] = "Wrong credentials. Please, try again.";
                return View(login);
            }
            TempData["Error"] = "Wrong credentials. Please, try again.";
            return View(login);
        }






        public IActionResult Register()
        {
            var response = new RegisterVM();
            return View(response);
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterVM register)
        {
            if (!ModelState.IsValid) return View(register);

            var user = await _userManager.FindByEmailAsync(register.EmailAddress);

            if (user != null)
            {
                TempData["Error"] = "This E-mail address is already in use";
                return View(register);
            }

            var newUser = new ApplicationUser()
            {
                Email = register.EmailAddress,
                UserName = register.EmailAddress,
                EmailConfirmed = true
            };

            var newUserResponse = await _userManager.CreateAsync(newUser, register.Password);

            if (newUserResponse.Succeeded) return RedirectToAction("Index", "Home");

            return RedirectToAction("Register", "Account");
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
