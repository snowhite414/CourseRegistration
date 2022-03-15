using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistration.Models
{
    public class Course
    {
        [Key]  [DisplayName("Course Id")]
        public int CourseId { get; set; }

        [DisplayName("Course Number")]
        public string CourseNumber { get; set; }

        [DisplayName("Course")]
        public string CourseName { get; set; }

        public string Description { get; set; }
    }
}
