using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using Ejemplo1.Models;

namespace Ejemplo1.Context
{
    public class BlogDbContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=blog.db");
        }
    }
}