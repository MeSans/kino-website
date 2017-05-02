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
        [RegularExpression("[A-z]+", ErrorMessage = "Disallowed characters in Title")]
        public string Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:g}", ApplyFormatInEditMode = true)]//Format date according to location
        public DateTime? ReleaseDate { get; set; }

        [StringLength(60)]
        [RegularExpression("[A-z]+", ErrorMessage = "Disallowed characters in Genre")]
        public string Genre { get; set; }

        [Range(0,5)]
        public int Rating { get; set; }

        [StringLength(200)]
        [RegularExpression("[A-z]+", ErrorMessage = "Disallowed characters in Description")]
        public string Description { get; set; }
        
        [Display(Name = "Youtube link")]
        [StringLength(100)]
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
