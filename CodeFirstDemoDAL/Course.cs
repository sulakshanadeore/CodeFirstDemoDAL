using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDemoDAL
{
    //database is created using these classes.
    //dtabase=--SchoolDB
    //classes---table name

    //1 course----M enrollments
    //    1 course ---M students
    [Table("Course")]
    public class Course
    {

        public ICollection<Enrollment> Enrollments { get; set; }
        public ICollection<Student> Students { get; set; }


        [Required]
        [Column(Order =2)]
        public string CrsName { get; set; }

        [Range(10000, 200000, ErrorMessage = "not in range")]
        [Column(Order =3)]
        public int Fees { get; set; }

        [Key]
        [Column("CourseID",Order =1,TypeName ="varchar")]
        [Required(ErrorMessage ="Its a compulsory field")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]   
        public int Crsid { get; set; }


   


    }
}
