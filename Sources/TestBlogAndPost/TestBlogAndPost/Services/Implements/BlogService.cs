using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestBlogAndPost.Database;
using TestBlogAndPost.Entities;
using TestBlogAndPost.Services.Interfaces;

namespace TestBlogAndPost.Services.Implements
{
    public class BlogService : IBlogService
    {
        private readonly IBlogService blogService;

        public bool AddNew(Blog data)
        {
            try
            {
                DatabaseContext context = new DatabaseContext();
                context.Blogs.Add(data);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Blog> GetLists()
        {
            DatabaseContext context = new DatabaseContext();
            return context.Blogs.ToList();
        }
    }
}