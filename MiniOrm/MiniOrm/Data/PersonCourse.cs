using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiniOrm.Data
{
    public class PersonCourse
    {
        [Key]
        [ForeignKey(nameof(Person))]
        public int PersonId { get; set; }

        [Key]
        [ForeignKey(nameof(Course))]
        public int CourseId { get; set; }

        public Person Person { get; set; }

        public Course Course { get; set; }
    }
}
