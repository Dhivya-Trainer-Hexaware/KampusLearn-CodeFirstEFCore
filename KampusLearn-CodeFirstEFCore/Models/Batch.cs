using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KampusLearn_CodeFirstEFCore.Models
{
    internal class Batch
    {
        [Key]//This annotation will create a Primary key.
        public int BatchNo { get; set; }
        public string BatchName { get; set; }
        public int NoOfParticipants { get; set; }
        public DateTime BatchStartDate { get; set; }
        public DateTime BatchEndDate { get; set; }
    }
}
