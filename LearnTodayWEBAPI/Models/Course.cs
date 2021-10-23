using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace LearnTodayWEBAPI.Models
{
    public partial class Course
    {
        public int CourseId { get; set; }
        public string Title { get; set; }
        public double Fees { get; set; }
        public string Description { get; set; }
        public string Trainer { get; set; }
        public DateTime StartDate { get; set; }
    }
}
