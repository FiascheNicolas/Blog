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
            return View();
        }

        public IActionResult Post()
        {
            return View();
        }

        public IActionResult Edit()
        {
            return View(new Post());
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Post _post)
        {
            _repo.AddPost(_post);
            if (await _repo.SaveChangesAsync())
            {
                return RedirectToAction("Index");
            }
            else {
                return View(_post);
            }
            
        }
    }
}