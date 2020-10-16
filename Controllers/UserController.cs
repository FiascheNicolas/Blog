using Blog.Data.Repository;
using Blog.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Controllers
{
    //[Authorize(Roles = "User")]
    public class UserController : Controller
    {
        private IRepository _repo;
        private  UserManager<IdentityUser> _userManager;

        public UserController(IRepository repo, UserManager<IdentityUser> userManager)
        {
            _repo = repo;
            _userManager = userManager;
        }

        public async Task<IActionResult> UserAdmin() {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            return View(new UserManagerViewModel
            {
                LstPost = _repo.GetAllPostByUser(user.Id)
            });
        }

        public IActionResult Users() {
            return View(/*_repo.GetUsers()*/);
        }
    }
}
