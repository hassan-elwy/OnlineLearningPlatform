using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLearningPlatform.Models
{
    public enum Levels
    {
   
        Beginner, 
        Intermediate,
        Advanced
    }
    public class Course
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public decimal Price { get; set; }

        public Levels level { get; set; }

        public bool IsPublished { get; set; }



        public DateTime? PublishDate
        {
            get => IsPublished ? PublishDate : null;
            set
            {
                if (IsPublished) PublishDate = value;
                else PublishDate = null;
            }
        }


        /*Navigation*/
        public int InstructorId { get; set; }
        public Instructor Instructor { get; set; }

        public ICollection<Enrollment> Enrollments = new List<Enrollment>();

    }
}
