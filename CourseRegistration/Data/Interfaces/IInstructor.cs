using CourseRegistration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistration.Data.Interfaces
{
    public interface IInstructor
    {
        void Create(Instructor input);            // create
        IEnumerable<Instructor> GetAll();         // read
        Instructor GetById(int id);               // read
        void Update(int id, Instructor input);    // update
        void Delete(int id);                      // delete
    }
}
