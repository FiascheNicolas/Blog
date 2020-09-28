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

        public IActionResult Index(int? idCategory)
        {
            var LstPosts = idCategory == null ? _repo.GetAllPost() : _repo.GetAllPost(idCategory.Value);
            return View(LstPosts);
        }

        public IActionResult Post(int id)
        {
            var post = _repo.GetPost(id);
            return View(post);
        }

        [HttpGet("/Image/{image}")]
        public IActionResult Image(string image) {
            var ext = image.Substring(image.LastIndexOf('.') + 1);
            return new FileStreamResult(_fileManager.ImageStream(image), $"image/{ext}");
        }
    }
}