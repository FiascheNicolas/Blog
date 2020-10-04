using Blog.Data.Repository;
using Blog.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Controllers
{
    public class AuthController : Controller
    {
        private UserManager<IdentityUser> _userManager;
        private SignInManager<IdentityUser> _signInManager;
        private IRepository _repo;

        public AuthController(SignInManager<IdentityUser> signInManager, IRepository repo, UserManager<IdentityUser> userManager)
        {
            _repo = repo;
            _signInManager = signInManager;
            _userManager = userManager;
        }

        public IActionResult Login() {
            return View(new LoginViewModel());
        }

        public IActionResult SignIn()
        {
            return View(new SignInViewModel());
        }

        [HttpPost]
        public IActionResult SignIn(SignInViewModel vm)
        {
            if (!_repo.UserExist(vm.UserName))
            {
                var user = new IdentityUser
                {
                    UserName = vm.UserName,
                    Email = vm.Email,
                };
                _userManager.CreateAsync(user, vm.Password).GetAwaiter().GetResult();
                _userManager.AddToRoleAsync(user, "User").GetAwaiter().GetResult();
                if (LoginUser(vm.UserName, vm.Password, false, false))
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    return RedirectToAction("SignIn", "Auth");
                }
            }
            else
            {
                return RedirectToAction("SignIn","Auth");
            }
        }

        public bool LoginUser(string UserName, string Password, bool IsPersistent, bool LockOutOnFailure)
        {
            return _signInManager.PasswordSignInAsync(UserName, Password, IsPersistent, LockOutOnFailure).GetAwaiter().GetResult().Succeeded;
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel vm)
        {
            if (LoginUser(vm.UserName, vm.Password, false, false))
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("Login", "Auth");
            }
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
