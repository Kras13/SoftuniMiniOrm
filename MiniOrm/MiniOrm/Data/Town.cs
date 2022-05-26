using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniOrm.Data
{
    public class Town
    {
        public Town()
        {
            this.People = new HashSet<Person>();
        }

        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Person> People { get; set; }
    }
}
