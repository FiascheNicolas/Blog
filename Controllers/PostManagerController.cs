using Blog.Data.FileManager;
using Blog.Data.Repository;
using Blog.Models;
using Blog.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Controllers
{
    public class PostManagerController : Controller 
    {
        private IRepository _repo;
        private IFileManager _fileManager;
        private UserManager<IdentityUser> _userManager;

        public PostManagerController(IRepository repo, IFileManager fileManager, UserManager<IdentityUser> userManager) {
            _repo = repo;
            _fileManager = fileManager;
            _userManager = userManager;
        }

        public IActionResult Edit(int? id)
        {
            var categories = GetCategories();
            //Create post
            if (id == null)
            {
                ViewData["Categories"] = new SelectList(categories, "Category", "Category", categories.FirstOrDefault().Category);
                return View(new PostViewModel());
            }
            //Edit post
            else
            {
                var post = _repo.GetPost(id.Value);
                ViewData["Categories"] = new SelectList(categories, "Category", "Category", post.Category == null ? categories.FirstOrDefault().Category : post.Category);
                return View(new PostViewModel
                {
                    Id = post.Id,
                    Title = post.Title,
                    Body = post.Body,
                    CurrentImage = post.Image,
                    Description = post.Description,
                    Tags = post.Tags
                });
            }
        }

        [HttpPost]
        public async Task<IActionResult> Edit(PostViewModel vm)
        {
            var _post = new Post
            {
                Id = vm.Id,
                Title = vm.Title,
                Body = vm.Body,
                Description = vm.Description,
                Tags = vm.Tags,
                Category = vm.Category,
                IdOwner = _userManager.GetUserId(User)
            };

            if (vm.Image == null)
            {
                _post.Image = vm.CurrentImage;
            }
            else
            {
                if (!string.IsNullOrEmpty(vm.CurrentImage))
                {
                    _fileManager.RemoveImage(vm.CurrentImage);
                }

                _post.Image = await _fileManager.SaveImage(vm.Image);
            }

            if (_post.Id != 0)
            {
                _repo.UpdatePost(_post);
            }
            else
            {
                _repo.AddPost(_post);
            }
            if (await _repo.SaveChangesAsync())
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View(_post);
            }
        }

        public List<Categories> GetCategories()
        {
            return _repo.GetAllCategories();
        }
    }
}
