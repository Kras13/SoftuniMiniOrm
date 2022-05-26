using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniOrm.Data
{
    public class Course
    {
        public Course()
        {
            this.CoursePeople = new HashSet<PersonCourse>();    
        }

        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<PersonCourse> CoursePeople { get; set; }
    }
}
