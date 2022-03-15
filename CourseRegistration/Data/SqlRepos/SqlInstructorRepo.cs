using CourseRegistration.Data.Interfaces;
using CourseRegistration.Models;
using System.Collections.Generic;
using System.Linq;

namespace CourseRegistration.Data.SqlRepos
{
    public class SqlInstructorRepo : IInstructor
    {
        private readonly AppDbContext _context;

        public SqlInstructorRepo(AppDbContext context)
        {
            _context = context; 
        }
        public void Create(Instructor input)
        {
            _context.Instructors.Add(input);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var instructorToDelete = _context.Instructors.FirstOrDefault(i => i.InstructorId  == id);

            if (instructorToDelete != null)
            {
                _context.Remove(instructorToDelete);
                _context.SaveChanges();
            }
        }

        public IEnumerable<Instructor> GetAll()
        {
           return _context.Instructors;
        }

        public Instructor GetById(int id)
        {
            return _context.Instructors.FirstOrDefault(i => i.InstructorId == id);
        }

        public void Update(int id, Instructor input)
        {
            var instructorInDb = _context.Instructors.FirstOrDefault(i => i.InstructorId == id);

            if (instructorInDb != null)
            {
                instructorInDb.FirstName = input.FirstName;
                instructorInDb.LastName = input.LastName;
                instructorInDb.EmailAddress = input.EmailAddress;
                instructorInDb.CourseId = input.CourseId;
                _context.SaveChanges();
            }
        }
    }
}
