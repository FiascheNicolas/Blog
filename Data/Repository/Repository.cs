using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.Models;

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

        public List<Post> GetAllPost(int idCategory)
        {
            //Func<Post, bool> InCategory = (post) => { return post.Category.ToLower().Equals(GetCategoriesById(idCategory).Category.ToLower()); };
            Categories category = GetCategoriesById(idCategory);
            return _ctx.Posts.Where(post => post.Category.ToLower().Equals(category.Category.ToLower())).ToList();
        }

        public Post GetPost(int id)
        {
            return _ctx.Posts.Where(post => post.Id == id).FirstOrDefault();
        }

        public void RemovePost(int id)
        {
            _ctx.Posts.Remove(GetPost(id));
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
    }
}
