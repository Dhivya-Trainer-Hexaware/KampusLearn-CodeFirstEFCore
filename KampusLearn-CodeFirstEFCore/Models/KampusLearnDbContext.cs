using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace KampusLearn_CodeFirstEFCore.Models
{
    internal class KampusLearnDbContext:DbContext
    {

        public DbSet<Course> Courses { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Student> Students { get; set; }

     //   public DbSet<Batch> Batches { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=Dhivya-pc\\Sqlexpress;Database=KampusLearn_Hexa;integrated security=true");
        }


    }
}
