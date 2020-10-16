using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.Models;
using Blog.Models.Comments;
using Microsoft.EntityFrameworkCore;

namespace Blog.Data.Repository
{
    public class Repository : IRepository
    {
        private AppDbContext _ctx;
        public Repository(AppDbContext ctx)
        {
            _ctx = ctx;
        }

        public void AddPost(Post post)
        {
            _ctx.Posts.Add(post);
        }

        public List<Post> GetAllPost()
        {
            return _ctx.Posts.ToList();
        }

        public List<Post> GetAllPostByUser(string idUser)
        {
            return _ctx.Posts.Where(user => user.IdOwner.Equals(idUser)).ToList();
        }

        public List<Post> GetAllPost(int idCategory)
        {
            Categories category = GetCategoriesById(idCategory);
            return _ctx.Posts.Where(post => post.Category.ToLower().Equals(category.Category.ToLower())).ToList();
        }

        public Post GetPost(int id)
        {
            return _ctx.Posts
                .Include(p => p.MainComments)
                .ThenInclude(mc => mc.SubComments)
                .FirstOrDefault(post => post.Id == id);
        }

        public void RemovePost(int id)
        {
            Post post = GetPost(id);
            _ctx.Posts.Remove(post);

            foreach (MainComment mc in post.MainComments)
            {
                _ctx.MainComments.Remove(mc);

                foreach (SubComment sc in mc.SubComments)
                {
                    _ctx.SubComments.Remove(sc);
                }
            }
        }

        public void UpdatePost(Post post)
        {
            _ctx.Posts.Update(post);
        }

        public async Task<bool> SaveChangesAsync()
        {
            if (await _ctx.SaveChangesAsync() > 0)
            {
                return true;
            }
            else {
                return false;
            }
            throw new NotImplementedException();
        }

        public List<Categories> GetAllCategories()
        {
            return _ctx.Categories.ToList();
        }

        public Categories GetCategoriesByName(string category)
        {
            return _ctx.Categories.Where(x => x.Category.ToLower().Equals(category.ToLower())).FirstOrDefault();
        }

        public Categories GetCategoriesById(int id)
        {
            return _ctx.Categories.Where(x => x.Id == id).FirstOrDefault();
        }

        public void AddSubComment(SubComment comment)
        {
            _ctx.SubComments.Add(comment);
        }

        public bool UserExist(string user)
        {
            return _ctx.Users.Any(u => u.UserName == user);
        }

        public List<ApplicationUser> GetUsers()
        {
            return _ctx.ApplicationUser.Where(x => x.Level != 1).ToList();
        }
    }
}
