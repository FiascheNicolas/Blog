using Blog.Data.Repository;
using Blog.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
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

        public PanelController(IRepository repo) {
            _repo = repo;
        }

        public IActionResult Index() {
            var LstPosts = _repo.GetAllPost();
            return View(LstPosts);
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return View(new Post());
            }
            else
            {
                var post = _repo.GetPost(id.Value);
                return View(post);
            }
        }

        public async Task<IActionResult> Remove(int id)
        {
            _repo.RemovePost(id);
            await _repo.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Post _post)
        {
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
    }
}
