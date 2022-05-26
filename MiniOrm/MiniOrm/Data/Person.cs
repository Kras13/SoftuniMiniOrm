using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiniOrm.Data
{
    public class Person
    {
        public Person()
        {
            this.PersonCourses = new HashSet<PersonCourse>();
        }

        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        [ForeignKey(nameof(Town))]
        public int TownId { get; set; }

        public Town Town { get; set; }

        public ICollection<PersonCourse> PersonCourses { get; set; }
    }
}
