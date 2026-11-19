using Microsoft.EntityFrameworkCore;
using OnlineLearningPlatform.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLearningPlatform.Contexts
{
    internal class MyDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=USERK\\SQLEXPRESS;Database=RouteLearnPlatfrom;Trusted_Connection=True;Trust Server Certificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Student> Students { get; set; }

        public DbSet<Category>Categories { get; set; }

        public DbSet<Instructor>Instructors { get; set; }

        public DbSet<Enrollment> Enrollments { get; set; }  

        public DbSet<Course> Courses { get; set; }
    }
}
