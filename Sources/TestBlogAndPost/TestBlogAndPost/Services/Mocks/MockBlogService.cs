using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestBlogAndPost.Entities;
using TestBlogAndPost.Services.Interfaces;

namespace TestBlogAndPost.Services.Mocks
{
    public class MockBlogService : IBlogService
    {
        private static List<Blog> ListBlogs = new List<Blog>();

        public bool AddNew(Blog data)
        {
            ListBlogs.Add(data);
            return true;
        }

        public List<Blog> GetLists()
        {
            return ListBlogs;
        }
    }
}