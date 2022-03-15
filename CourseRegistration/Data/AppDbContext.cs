using CourseRegistration.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistration.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }
        public DbSet<Instructor> Instructors { set; get; }

        public DbSet<Student> Students { set; get; }

        public DbSet<Course> Courses { set; get; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Instructor>().HasData(
                 new Instructor { InstructorId = 1, FirstName = "Michelle", LastName = "Lund", EmailAddress = "mlund@yahoo.com", CourseId = 1 },
            new Instructor { InstructorId = 2, FirstName = "Jason", LastName = "Capa", EmailAddress = "roblox@gmail.com", CourseId = 2 },
            new Instructor { InstructorId = 3, FirstName = "Abraham", LastName = "Diaby", EmailAddress = "ADiaby@gmail.com", CourseId = 3 },
            new Instructor { InstructorId = 4, FirstName = "Gabriel", LastName = "Monzon", EmailAddress = "Sniper@gmail.com", CourseId = 4 }
            );

            modelBuilder.Entity<Student>().HasData(
                new Student { StudentId = 1, FirstName = "Rhiane", LastName = "Cruz", EmailAddress = "cookie@gmail.com", PhoneNumber = 1111234, CourseId = 1},
            new Student { StudentId = 2, FirstName = "Kassandra", LastName = "Ruiz", EmailAddress = "minecraft@gmail.com", PhoneNumber = 2221234, CourseId = 2 },
            new Student { StudentId = 3, FirstName = "Leann", LastName = "Rymes", EmailAddress = "music@gmail.com", PhoneNumber = 3331234, CourseId = 3 },
            new Student { StudentId = 4, FirstName = "Luisa", LastName = "Paras", EmailAddress = "lparas@gmail.com", PhoneNumber = 4441234, CourseId = 4 }
                );

            modelBuilder.Entity<Course>().HasData(
                new Course { CourseId = 1, CourseNumber = "C1", CourseName = "C# Programming", Description = "This course provides an introduction to C# in an integrated development environment using Visual Studio and the Microsoft .NET Core Framework." },
            new Course { CourseId = 2, CourseNumber = "NC1", CourseName = ".Net Core", Description = "It explores new Core features for familiar tasks such as testing, logging, data access, and networking." },
            new Course { CourseId = 3, CourseNumber = "ANC1", CourseName = "ASP. Net Core", Description = "The focus of the course is on creating applications with ASP.NET Core in order to build full stack Single Page Applications and REST APIs." },
            new Course { CourseId = 4, CourseNumber = "ANC1", CourseName = "FrontEnd Framework", Description = "Students will learn to develop dynamic Single Page Web Applications using three of today’s most popular front-end frameworks: Angular, React, and Vue." }
                );
        }
    }
}
