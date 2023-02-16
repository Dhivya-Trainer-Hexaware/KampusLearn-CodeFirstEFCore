using System;
using System.Collections.Generic;
using System.Text;

namespace KampusLearn_CodeFirstEFCore.Models
{
    internal class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int Contact { get; set; }
        public string StudentEmail { get; set; }
    }
}
