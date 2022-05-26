using MiniOrmFramework;

namespace MiniOrm.Data
{
    public class CourseContext : DbContext
    {
        public CourseContext(string connectionString) :
            base(connectionString)
        {
        }

        public DbSet<Person> People { get; }

        public DbSet<Course> Courses { get; }

        public DbSet<Town> Towns { get; }

        public DbSet<PersonCourse> PeopleCourses { get; }
    }
}
