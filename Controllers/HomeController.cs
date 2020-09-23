using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.Models;
using Blog.Data;

namespace Blog.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _ctx;
        public HomeController(AppDbContext ctx)
        {
            _ctx = ctx;
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
            _ctx.Posts.Add(_post);
            await _ctx.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}