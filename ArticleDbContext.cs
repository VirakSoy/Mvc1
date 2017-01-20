using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ASP_MVC1.Models
{
    public class ArticleDbContext : DbContext
    {
        public DbSet<Article> article { get; set; }
    }
}