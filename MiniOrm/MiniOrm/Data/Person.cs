using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiniOrm.Data
{
    public class Person
    {
        public Person()
        {
            this.PersonCourses = new HashSet<PersonCourse>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        [ForeignKey(nameof(Department))]
        public int DepartmentId { get; set; }

        public Town Department { get; set; }

        public ICollection<PersonCourse> PersonCourses { get; set; }
    }
}
