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
        public string Name { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public int Rating { get; set; }
        public string Description { get; set; }
        public string YouTubeLink { get; set; }


        public ICollection<Screening> Screenings { get; set; }


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
