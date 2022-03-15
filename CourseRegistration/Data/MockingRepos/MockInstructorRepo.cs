using CourseRegistration.Data.Interfaces;
using CourseRegistration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistration.Data.MockingRepos
{
    public class MockInstructorRepo : IInstructor
    {
        private static List<Instructor> instructors = new List<Instructor>
        {
           new Instructor { InstructorId = 1, FirstName = "Michelle", LastName = "Lund", EmailAddress = "mlund@yahoo.com", CourseId = 1 },
            new Instructor { InstructorId = 2, FirstName = "Jason", LastName = "Capa", EmailAddress = "roblox@gmail.com", CourseId = 2 },
            new Instructor { InstructorId = 3, FirstName = "Abraham", LastName = "Diaby", EmailAddress = "ADiaby@gmail.com", CourseId = 3 },
            new Instructor { InstructorId = 4, FirstName = "Gabriel", LastName = "Monzon", EmailAddress = "Sniper@gmail.com", CourseId = 4 }
        };
        public void Create(Instructor input)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Instructor GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Instructor> GetAll()
        {
            return instructors;
        }

        public void Update(int id, Instructor input)
        {
            throw new NotImplementedException();
        }
    }
}
