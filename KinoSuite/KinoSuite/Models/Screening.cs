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
        [Key]
        public int ID { get; set; }

        [Display(Name = "Screening start")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:g}", ApplyFormatInEditMode = true)]//Format date according to location
        public DateTime? ScreeningStart { get; set; }

        [Display(Name = "Screening end")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:g}", ApplyFormatInEditMode = true)]//Format date according to location
        public DateTime? ScreeningEnd { get; set; }

        [Display(Name = "Price")]
        [DataType(DataType.Currency)]
        public float? BasePrice { get; set; }

        [Display(Name = "Premiere")]//Smell -> not direct property to name
        public Boolean? IsPremiere { get; set; }

        [Display(Name = "Subtitles")]
        [StringLength(60)]
        [RegularExpression(@"^[\p{L}\p{N}]*$", ErrorMessage = "Disallowed characters in subtitle language")]//Any unicode letter or number
        public string SubtitleLanguage { get; set; }


        //Foreign keys
        //Screening Shows one movie in one venue
       // public int MovieRefId { get; set; }//Warning -> possibly unneccessary
       // [ForeignKey("MovieRefId")]
        public virtual Movie Movie { get; set; }

      //  public int VenueRefId { get; set; }//Warning -> possibly unneccessary
      //  [ForeignKey("VenueRefId")]
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
