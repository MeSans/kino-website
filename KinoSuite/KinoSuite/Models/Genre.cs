using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KinoSuite.Models
{
    public class Genre
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [StringLength(60)]
        [Required(ErrorMessage = "Movie must have a Title")]
        [RegularExpression(@"^[a-zA-Z1-9''-'\s]{1,40}$", ErrorMessage = "Disallowed characters in Title")]
        public string Name { get; set; }

        public virtual ICollection<Movie> Movies { get; set; }
    }
}