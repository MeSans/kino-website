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

        [StringLength(60)]
        [RegularExpression(@"^[\p{L}\p{N}]*$", ErrorMessage = "Disallowed characters in name")]//Any unicode letter or number
        public string Name { get; set; }

        [StringLength(60)]
        [RegularExpression(@"^[\p{L}\p{N}]*$", ErrorMessage = "Disallowed characters in surname")]//Any unicode letter or number
        public string Surname { get; set; }

        [Display(Name = "Work start date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:g}", ApplyFormatInEditMode = true)]//Format date according to location
        public DateTime? CreationDate { get; set; }

        [Display(Name ="Email adress")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string EMail { get; set; }

        [Display(Name ="phone number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid Phone number")]//
        public string Phone { get; set; }
    }
}
