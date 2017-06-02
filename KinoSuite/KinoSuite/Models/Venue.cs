using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.Owin.BuilderProperties;

namespace KinoSuite.Models
{
    [Table("Venue")]
    public class Venue
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [StringLength(40)]
        [RegularExpression(@"^[a-zA-Z1-9''-'\s]{1,40}$", ErrorMessage = "Disallowed characters in Venue name")]
        public string Name { get; set; }

        [Display(Name = "Venue adress")]
        [StringLength(60)]
        public string Adress { get; set; }

        public virtual ICollection<Screening> Screenings { get; set; }

    }
}


//Venue
//ID
//Adress
