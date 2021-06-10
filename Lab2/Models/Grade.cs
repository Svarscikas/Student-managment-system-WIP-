using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Lab2.Models
{
    public class Grade
    {
        public int GradeID { get; set; }
        public int EnrollmentID { get; set; }
        public string ProjectName { get; set; }
        public int Mark { get; set; }
        public virtual Enrollment Enrollment { get; set; }
    }
}