using System;
using System.Collections.Generic;
using System.Text;

namespace KampusLearn_CodeFirstEFCore.Models
{
    internal class Trainer
    {
        public int TrainerId { get; set; }
        public string TrainerName { get; set; }
        public string Skills { get; set; }
        public int Contact { get; set; }
        public int YearsOfExperience { get; set; }
    }
}
