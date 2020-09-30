using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.Models;
using Blog.Data;
using Blog.Data.Repository;
using Blog.Data.FileManager;
using Blog.Models.Comments;
using Blog.ViewModels;

namespace Blog.Controllers
{
    public class HomeController : Controller
    {
        private IRepository _repo;
        private IFileManager _fileManager;

        public HomeController(IRepository repo, IFileManager fileManager) {
            _repo = repo;
            _fileManager = fileManager;
        }

        public IActionResult Index(int? idCategory) => View(idCategory == null ? _repo.GetAllPost() : _repo.GetAllPost(idCategory.Value));

        public IActionResult Post(int id) => View(_repo.GetPost(id));

        public async Task<IActionResult> Comment(CommentViewModel vm) {
            if (!ModelState.IsValid) {
                return RedirectToAction("Post", new { id = vm.PostId });
            }
            var post = _repo.GetPost(vm.PostId);
            if (vm.MainCommentId == 0)
            {
                post.MainComments = post.MainComments ?? new List<MainComment>();
                post.MainComments.Add(new MainComment
                {
                    Message = vm.Message,
                    Created = DateTime.Now
                });
                _repo.UpdatePost(post);
            }
            else {
                var comment = new SubComment
                {
                    MainCommentId =  vm.MainCommentId,
                    Message = vm.Message,
                    Created = DateTime.Now
                };
                _repo.AddSubComment(comment);
            }

            await _repo.SaveChangesAsync();

            return RedirectToAction("Post", new { id = vm.PostId });
        }

        [HttpGet("/Image/{image}")]
        [ResponseCache(CacheProfileName = "Monthly")]
        public IActionResult Image(string image)=>
            new FileStreamResult(_fileManager.ImageStream(image), $"image/{image.Substring(image.LastIndexOf('.') + 1)}");
        
    }
}