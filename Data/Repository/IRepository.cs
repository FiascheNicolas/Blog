using Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.Repository
{
    public interface IRepository
    {
        //Posts
        Post GetPost(int id);
        List<Post> GetAllPost();
        List<Post> GetAllPost(int idCategory);
        void RemovePost(int id);
        void UpdatePost(Post post);
        void AddPost(Post post);

        //Posts
        List<Categories> GetAllCategories();

        Task<bool> SaveChangesAsync();
    }
}
