using CourseRegistration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistration.Data.Interfaces
{
    public interface ICourse
    {
        void Create(Course input);            // create
        IEnumerable<Course> GetAll();         // read
        Course GetById(int id);               // read
        void Update(int id, Course input);    // update
        void Delete(int id);                  // delete
    }
}
