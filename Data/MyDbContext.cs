using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using mvc_project.Model;

namespace mvc_project.Data
{
    public class MyDbContext : DbContext
    {
        private const string connectionString = @"
        Data Source=localhost,1433;
        Initial Catalog=master;
        User ID=sa;
        Password=0914384022Duc";
        public MyDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder option) {
            base.OnConfiguring(option);
        }
    }
}