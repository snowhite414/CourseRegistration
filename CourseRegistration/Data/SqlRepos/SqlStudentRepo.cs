using CourseRegistration.Data.Interfaces;
using CourseRegistration.Models;
using System.Collections.Generic;
using System.Linq;

namespace CourseRegistration.Data.SqlRepos
{
    public class SqlStudentRepo : IStudent
    {
        private readonly AppDbContext _context;

        public SqlStudentRepo(AppDbContext context)
        {
            _context = context;
        }
        public void Create(Student input)
        {
            _context.Students.Add(input);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var studentToDelete = _context.Students.FirstOrDefault(s => s.StudentId == id);
            if (studentToDelete != null)
            {
                _context.Remove(studentToDelete);
                _context.SaveChanges();
            }
        }

        public IEnumerable<Student> GetAll()
        {
            return _context.Students;
        }

        public Student GetById(int id)
        {
           return _context.Students.FirstOrDefault(s => s.StudentId == id);
        }

        public void Update(int id, Student input)
        {
            var studentInDb = _context.Students.FirstOrDefault(s => s.StudentId == id);

            if(studentInDb != null)
            {
                studentInDb.FirstName = input.FirstName;
                studentInDb.LastName = input.LastName;
                studentInDb.EmailAddress = input.EmailAddress;
                studentInDb.PhoneNumber = input.PhoneNumber;
                studentInDb.CourseId = input.CourseId;
                _context.SaveChanges();
            }
        }
    }
}
