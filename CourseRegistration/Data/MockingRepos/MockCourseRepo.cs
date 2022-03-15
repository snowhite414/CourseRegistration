using CourseRegistration.Data.Interfaces;
using CourseRegistration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistration.Data.MockingRepos
{
    public class MockCourseRepo : ICourse
    {
        private static List<Course> courses = new List<Course>
        {
            new Course { CourseId = 1, CourseNumber = "C1", CourseName = "C# Programming", Description = "This course provides an introduction to C# in an integrated development environment using Visual Studio and the Microsoft .NET Core Framework." },
            new Course { CourseId = 2, CourseNumber = "NC1", CourseName = ".Net Core", Description = "It explores new Core features for familiar tasks such as testing, logging, data access, and networking." },
            new Course { CourseId = 3, CourseNumber = "ANC1", CourseName = "ASP. Net Core", Description = "The focus of the course is on creating applications with ASP.NET Core in order to build full stack Single Page Applications and REST APIs." },
            new Course { CourseId = 4, CourseNumber = "ANC1", CourseName = "FrontEnd Framework", Description = "Students will learn to develop dynamic Single Page Web Applications using three of today’s most popular front-end frameworks: Angular, React, and Vue." }
        };

        public void Create(Course input)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Course GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Course> GetAll()
        {
            return courses;
        }

        public void Update(int id, Course input)
        {
            throw new NotImplementedException();
        }
    }
}
