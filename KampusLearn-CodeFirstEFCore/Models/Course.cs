using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace KampusLearn_CodeFirstEFCore.Models
{
    public class Course
    {
        public int CourseId { get; set; }

        [Required] // Data annotation which will create a not null constraint 
        [Column(TypeName ="char(100)")]
        public string CourseName { get; set; }
        [Required]
        [Column(TypeName = "char(60)")]
        public string Technology { get; set; }

        [Column("CourseDuration")]
        public int DurationOfCourse { get; set; }

        public float? Price { get; set; }
    }
}
