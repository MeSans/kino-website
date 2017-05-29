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

        [Display(Name = "Venue adress")]
        [StringLength(60)]
        [RegularExpression(@"[\p{L}\s\.\'\,]*", ErrorMessage = "Disallowed characters in name")]
        public Address? Adress { get; set; }

        public virtual ICollection<Screening> Screenings { get; set; }

    }
}


//Venue
//ID
//Adress
