using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_12_25
{
    public  class Student
    {
        [Key] // primary key
        [DatabaseGenerated(DatabaseGeneratedOption.None)]// no identity

        [Required(ErrorMessage = "pls enter the studentid")]

        [Column("Sid")]
        public int Studentid { get; set; }

        [Required(ErrorMessage = "pls enter the studentname")]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "only alphebets are allowed")]
        [Column("studentfullname", TypeName = "varchar")]
        [MaxLength(20)]
        public string Studentname { get; set; }
        public DateTime DOB { get; set; }

        [Range(1, 12, ErrorMessage = "pls enter the valid class")]
        [Required(ErrorMessage = "pls enter the class")]
        public int Class { get; set; }

        [EmailAddress(ErrorMessage = "pls enter the valid Email")]
        [Column("Emailaddress", TypeName = "varchar")]
        [MaxLength(50)]
        public string Email { get; set; }




    }

}
