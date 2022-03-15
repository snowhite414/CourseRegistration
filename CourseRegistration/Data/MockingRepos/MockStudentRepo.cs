using CourseRegistration.Data.Interfaces;
using CourseRegistration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistration.Data.MockingRepos
{
    public class MockStudentRepo : IStudent
    {
        private static List<Student> students = new List<Student>
        {
            new Student { StudentId = 1, FirstName = "Rhiane", LastName = "Cruz", EmailAddress = "cookie@gmail.com", PhoneNumber = 1111234, CourseId = 1},
            new Student { StudentId = 2, FirstName = "Kassandra", LastName = "Ruiz", EmailAddress = "minecraft@gmail.com", PhoneNumber = 2221234, CourseId = 2 },
            new Student { StudentId = 3, FirstName = "Leann", LastName = "Rymes", EmailAddress = "music@gmail.com", PhoneNumber = 3331234, CourseId = 3},
            new Student { StudentId = 4, FirstName = "Luisa", LastName = "Paras", EmailAddress = "lparas@gmail.com", PhoneNumber = 4441234, CourseId = 4}
        };
        public void Create(Student input)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Student> GetAll()
        {
            return students;
        }

        public Student GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Student input)
        {
            throw new NotImplementedException();
        }
    }
}
