﻿using Blog.Data.FileManager;
using Blog.Data.Repository;
using Blog.Models;
using Blog.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Controllers
{
    [Authorize(Roles = "Admin")]
    public class PanelController : Controller
    {
        private IRepository _repo;
        private IFileManager _fileManager;

        public PanelController(IRepository repo, IFileManager fileManager) {
            _repo = repo;
            _fileManager = fileManager;
        }

        public IActionResult Index() {
            var LstPosts = _repo.GetAllPost();
            return View(LstPosts);
        }
        
        public async Task<IActionResult> Remove(int id)
        {
            _repo.RemovePost(id);
            await _repo.SaveChangesAsync();
            return RedirectToAction("Index");
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
                Category = vm.Category
            };

            if (vm.Image == null)
            {
                _post.Image = vm.CurrentImage;
            }
            else {

                if (!string.IsNullOrEmpty(vm.CurrentImage)) {
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
                return RedirectToAction("Index");
            }
            else
            {
                return View(_post);
            }

        }

        public List<Categories> GetCategories() {
            return _repo.GetAllCategories();
        }
    }
}
