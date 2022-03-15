using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistration.Models
{
    public class Student
    {
        [Key] [DisplayName("Student Id")]
        public int StudentId { get; set; }

        [DisplayName("First Name")]
        public string FirstName { get; set; }
        
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [DisplayName("Email Address")]
        public string EmailAddress { get; set; }

        [DisplayName("Phone Number")]
        public int PhoneNumber { get; set; }

        [ForeignKey("Course")] [DisplayName("Course Id")]
        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
