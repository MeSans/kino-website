using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KinoSuite.Models
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime? CreationDate { get; set; }
        public string EMail { get; set; } //Smell
        public string Phone { get; set; } //Smell
    }
}

//Employee
//ID
//Name
//Surname
//CreationDate?
//E-Mail?
//Phone?
