using CourseRegistration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistration.Data.Interfaces
{
    public interface IStudent
    {
        void Create(Student input);            // create
        IEnumerable<Student> GetAll();     // read
        Student GetById(int id);               // read
        void Update(int id, Student input);            // update
        void Delete(int id);                   // delete
    }
}
