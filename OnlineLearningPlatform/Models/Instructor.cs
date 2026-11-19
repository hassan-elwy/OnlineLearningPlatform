using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLearningPlatform.Models
{
    public class Instructor
    {
        public int Id { get; set; }
        
        public string FullName { get; set; }
        [EmailAddress]
        public string Email { get; set; }

        public string? bio { get; set; }

        public DateTime JoinAt { get; set; }


        /*Navigation*/

        public ICollection<Course>courses =new List<Course>();




    }
}
