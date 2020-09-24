using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.Models;
using Blog.Data;
using Blog.Data.Repository;

namespace Blog.Controllers
{
    public class HomeController : Controller
    {
        private IRepository _repo;

        public HomeController(IRepository repo) {
            _repo = repo;
        }

        public IActionResult Index() {
            var LstPosts = _repo.GetAllPost();
            return View(LstPosts);
        }

        public IActionResult Post(int id)
        {
            var post = _repo.GetPost(id);
            return View(post);
        }
    }
}