using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLearningPlatform.Models
{
    public class Enrollment
    {
        public int StudentId { get; set; }

        public Student Student { get; set; }

        public int CourseId { get; set; }

        public Course Course { get; set; }


        public DateTime EnrollmentDate { get; set; }


        public decimal ProgressPercentage { get; set; }

        public string Status { get; set; }

        public decimal? FinalGade 
        { 
            get
            { 
                if (Status == "Completed") 
                    return FinalGade; 
                else return null; 
            }
            set { }
        }

    }
}
