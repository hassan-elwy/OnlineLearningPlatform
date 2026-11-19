using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLearningPlatform.Models
{
    public class Student
    {
        public int Id { get; set; }

        public string FullName { get; set; }
        [EmailAddress]
        public string Email { get; set; }

        public DateTime DateOfBirth { get; set; }

        /*Navigation*/

        public ICollection<Enrollment> Enrollments = new List<Enrollment>();


    }
}
