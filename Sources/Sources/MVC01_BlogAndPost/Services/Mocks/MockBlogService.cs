using MVC01_BlogAndPost.Entities;
using MVC01_BlogAndPost.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC01_BlogAndPost.Services.Mocks
{
    public class MockBlogService : IBlogService
    {
        private static List<Blog> ListBlogs = new List<Blog>();

        public bool AddNew(Blog data)
        {
            ListBlogs.Add(data);
            return true;
        }

        public List<Blog> GetList()
        {
            return ListBlogs;
        }
    }
}