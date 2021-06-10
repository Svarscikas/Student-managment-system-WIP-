using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Lab2.Models
{
    public class Enrollment         
    {
        public int EnrollmentID { get; set; }
        [Required]
        public int CourseID { get; set; }
        [Required]
        public int StudentID { get; set; }
        public virtual ICollection<Grade> Grades { get; set; }
        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}