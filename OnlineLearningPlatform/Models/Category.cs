using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLearningPlatform.Models
{
    public class Category
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string? Desciption { get; set; }


        public int? CategoryId { get; set; }
        public Category? ParentCatgory {  get; set; }

        public  ICollection<Category> Subcategories = new List<Category>();

    }
}
