using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Collections.Generic;

namespace KinoSuite.Models
{
    [Table("Movie")]
    public class Movie
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
         
        [StringLength(60)]
        [Required(ErrorMessage = "Movie must have a Title")]
        [RegularExpression(@"^[a-zA-Z1-9''-'\s]{1,40}$", ErrorMessage = "Disallowed characters in Title")]
        public string Title { get; set; }


        [Display(Name = "Release Date")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:g}", ApplyFormatInEditMode = true)]//Format date according to location
        public DateTime? ReleaseDate { get; set; } = DateTime.Now;

        
        public int? GenreId { get; set; }
        public virtual Genre Genre { get; set; }

        [Range(0,5)]
        public int Rating { get; set; }

        [StringLength(200)]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,200}$", ErrorMessage = "Disallowed characters in Description")]
        public string Description { get; set; }
        
        [Display(Name = "Youtube link")]
        [StringLength(100)]
        public string YouTubeLink { get; set; }

        public virtual ICollection<Screening> Screenings { get; set; }
        
        //Currently [6/2/2017] contains just one file. 
        //Should stay as list for it is very likely that site will need more files per movie in future.
        public virtual ICollection<File> Files { get; set; }


    }
}
