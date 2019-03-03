using MVC01_BlogAndPost.Database;
using MVC01_BlogAndPost.Entities;
using MVC01_BlogAndPost.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC01_BlogAndPost.Services.Implements
{
    public class BlogService : IBlogService
    {
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

        public List<Blog> GetList()
        {
            DatabaseContext context = new DatabaseContext();
            return context.Blogs.ToList();
        }
    }
}