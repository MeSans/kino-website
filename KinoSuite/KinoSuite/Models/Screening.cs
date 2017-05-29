using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KinoSuite.Models
{
    [Table("Screening")]
    public class Screening
    {
        
        [Key, Column(Order = 0), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Display(Name = "Screening start")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:g}", ApplyFormatInEditMode = true)]//Format date according to location
        public DateTime? ScreeningStart { get; set; }

        [Display(Name = "Screening end")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:g}", ApplyFormatInEditMode = true)]//Format date according to location
        public DateTime? ScreeningEnd { get; set; }

        [Display(Name = "Price")]
        [DataType(DataType.Currency)]
        public float? BasePrice { get; set; }

        [Display(Name = "Premiere")]
        public Boolean? IsPremiere { get; set; }

        [Display(Name = "Subtitles")]
        [StringLength(60)]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "Disallowed characters in subtitle language")]
        public string SubtitleLanguage { get; set; }


        //Foreign keys
        //Screening Shows one movie in one venue
        [Key, Column(Order = 1), ForeignKey("Movie")]
        public int MovieId { get; set; }
        public virtual Movie Movie { get; set; }

        [Key, Column(Order = 2), ForeignKey("Venue")]
        public int VenueId { get; set; }
        public virtual Venue Venue { get; set; }
    }
}

//Screening
//ID
//  Id_Movie
//  Id_Venue
//ScreeningStart
//ScreeningEnd
//BasePrice
//IsPremiere
//Language
//SubtitleLanguage
