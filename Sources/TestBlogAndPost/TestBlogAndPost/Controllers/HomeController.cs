using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestBlogAndPost.Entities;
using TestBlogAndPost.Services.Interfaces;
using TestBlogAndPost.ViewModels;

namespace TestBlogAndPost.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBlogService blogService;

        public HomeController(IBlogService blogService)
        {
            this.blogService = blogService;
        }

        public ActionResult Index()
        {
            HomeIndexViewModel viewModel = new HomeIndexViewModel();
            viewModel.ListBlogs = blogService.GetLists();

            if(viewModel.ListBlogs.Count <= 0)
            {
                for(var i = 0; i < 10; ++i)
                {
                    blogService.AddNew(new Blog()
                    {
                        BlogId = i + 1,
                        Title = "Title " + (i + 1),
                        Content = "Content " + (i + 1)
                    });
                }
            }

            viewModel.ListBlogs = blogService.GetLists();

            return View(viewModel);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}