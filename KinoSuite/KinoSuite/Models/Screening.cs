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
        public DateTime? ScreeningStart { get; set; }
        public DateTime? ScreeningEnd { get; set; }
        public int BasePrice { get; set; }
        public Boolean? IsPremiere { get; set; }
        public string SubtitleLanguage { get; set; }


        //Foreign keys
        public Movie Movie { get; set; }
        public Venue Venue { get; set; }
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
