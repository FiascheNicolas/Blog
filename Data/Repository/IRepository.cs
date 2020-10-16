using Blog.Models;
using Blog.Models.Comments;
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
        List<Post> GetAllPostByUser(string idUser);
        void RemovePost(int id);
        void UpdatePost(Post post);
        void AddPost(Post post);
        void AddSubComment(SubComment comment);

        //Posts
        List<Categories> GetAllCategories();

        //Users
        bool UserExist(string user);
        List<ApplicationUser> GetUsers();

        Task<bool> SaveChangesAsync();
    }
}
