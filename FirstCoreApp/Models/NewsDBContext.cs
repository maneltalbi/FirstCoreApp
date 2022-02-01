using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstCoreApp.Models
{
    public class NewsDBContext : DbContext
    {
        public NewsDBContext(DbContextOptions<NewsDBContext> options)
            : base(options)
        {
        }

        public DbSet <News> News { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Teammember> Teammembers { get; set; }
        // public DbSet<ContactUs> Contacts { get; set; }



    }
}
