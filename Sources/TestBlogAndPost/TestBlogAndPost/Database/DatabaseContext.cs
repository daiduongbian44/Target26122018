using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TestBlogAndPost.Entities;

namespace TestBlogAndPost.Database
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("MyDatabaseContext") { }

        public DbSet<Blog> Blogs { get; set; }
    }
}