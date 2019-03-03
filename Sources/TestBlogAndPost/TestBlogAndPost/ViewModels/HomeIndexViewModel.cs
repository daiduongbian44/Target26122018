using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestBlogAndPost.Entities;
using TestBlogAndPost.Services.Interfaces;

namespace TestBlogAndPost.ViewModels
{
    public class HomeIndexViewModel
    {
        public List<Blog> ListBlogs { get; set; }

    }
}