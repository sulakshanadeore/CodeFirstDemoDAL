using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDemoDAL
{
    //SchoolContent:DbContext---represent the database
    public class SchoolContext:DbContext
    {
        public SchoolContext():base("SchoolContext")
        {
            Database.SetInitializer<SchoolContext>(new CreateDatabaseIfNotExists<SchoolContext>());


            //Database.SetInitializer<SchoolContext>(new DropCreateDatabaseAlways<SchoolContext>());

            //Database.SetInitializer<SchoolContext>(new DropCreateDatabaseIfModelChanges<SchoolContext>());



        }


        public virtual DbSet<Student> GetStudents { get; set; }
        public virtual DbSet<Course> GetCourses { get; set; }

        public virtual DbSet<Enrollment> GetEnrollments { get; set; }

    }
}
