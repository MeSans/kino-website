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
        public int ID { get; set; }

        [Display(Name = "Venue adress")]
        [StringLength(60)]
        public Address? Adress { get; set; }//WARNING -> no validation (how to validate adress???)

        public virtual ICollection<Screening> Screenings { get; set; }

    }
}


//Venue
//ID
//Adress
