using MVC01_BlogAndPost.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC01_BlogAndPost.Database
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("MyDatabaseContext") { }

        public DbSet<Blog> Blogs { get; set; }
    }
}