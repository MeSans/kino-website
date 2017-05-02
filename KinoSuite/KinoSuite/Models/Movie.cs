using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KinoSuite.Models
{
    [Table("Movie")]
    public class Movie
    {
        [Key]
        public int ID { get; set; }
         
        [StringLength(60)]
        [Required(ErrorMessage = "Movie must have a Title")]
        [RegularExpression(@"^[\p{L}\p{N}]*$", ErrorMessage = "Disallowed characters in Title")]//Any unicode letter or number
        public string Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:g}", ApplyFormatInEditMode = true)]//Format date according to location
        public DateTime? ReleaseDate { get; set; }

        [StringLength(60)]
        [RegularExpression(@"^[\p{L}\p{N}]*$", ErrorMessage = "Disallowed characters in Genre")]//Any unicode letter or number
        public string Genre { get; set; }

        [Range(0,5)]
        public int Rating { get; set; }

        [StringLength(200)]
        [RegularExpression(@"^[\p{L}\p{N}]*$", ErrorMessage = "Disallowed characters in Description")]//Any unicode letter or number
        public string Description { get; set; }
        
        [Display(Name = "Youtube link")]
        [StringLength(300)]
        public string YouTubeLink { get; set; }

        
        public virtual ICollection<Screening> Screenings { get; set; }


    }
}
//movie
//id
//  id_director
//name
//releasedate
//genre
//releasedate
//rating
//description
//  id_moviepicture
//youtubelink
