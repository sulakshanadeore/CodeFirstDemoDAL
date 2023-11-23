using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDemoDAL
{
    //1 course---M students
    //1 course--M Enrollments
    //1 student---1 Course
    [Table("Admissions")]
    public class Enrollment
    {
        [Key]
        [Column(Order =1)]
        public int EnrollmentID { get; set; }
        [Column(Order = 2)]
        public int Crsid { get; set; }

        [Column(Order = 3)]
        public int Rollno { get; set; }

        [ForeignKey("Rollno")]
        public virtual Student StudentDetails { get; set; }

        [ForeignKey("Crsid")]
        public virtual Course CourseDetails { get; set; }



    }
}
