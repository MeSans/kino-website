using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KinoSuite.Models
{
    [Table("Manager")]
    public class Manager
    {
        [Key]
        public int ID { get; set; }
    
        [StringLength(60)]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "Disallowed characters in name")]
        public string Name { get; set; }

        [StringLength(60)]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "Disallowed characters in surname")]
        public string Surname { get; set; }


        [Display(Name = "Work start date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:g}", ApplyFormatInEditMode = true)]//Format date according to location
        public DateTime? CreationDate { get; set; }

        [Display(Name = "Email adress")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string EMail { get; set; }

        [Display(Name = "phone number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"(\+?\d{3}[\-\ ]?)?\d{8}", ErrorMessage = "Not a valid Phone number")]//
        public string Phone { get; set; }
    }
}