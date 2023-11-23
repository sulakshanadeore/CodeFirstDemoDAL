using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDemoDAL
{
    //1 student--1 crs
    [Table("Stud")]
    public class Student
    {
        [Key]
        [Required]
        public int Rollno { get; set; }
        [Required]
        public string Name { get; set; }

        [EmailAddress(ErrorMessage ="Not a valid email id")]
        public string Email { get; set; }

        public virtual int Crsid { get; set; }


    }



}
