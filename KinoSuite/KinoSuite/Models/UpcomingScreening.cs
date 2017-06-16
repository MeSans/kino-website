using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KinoSuite.Models;

namespace KinoSuite.Models
{
    public class UpcomingScreening
    {
        public UpcomingScreening()
        {
            this.Image = new byte[] { 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20 }; ;
            this.length = 0;
            //this.rating = 0;
            this.Title = "";
            this.genre = "";
            this.venue = "";
            this.startTime = DateTime.MinValue;
            this.language = "";
            this.Description = "";
            this.subtitleLanguage = "";
            this.youtube_link = "";
            this.isPremiere = false;


        }
        public byte[] Image { get; set; }
        public string Title { get; set; }
        public string genre { get; set; }
        public string Description { get; set; }
        public DateTime? startTime { get; set; }
        public string language { get; set; }
        public string subtitleLanguage { get; set; }
        public bool isPremiere { get; set; }
        public int? length { get; set; }
        public string youtube_link { get; set; }
        public string venue { get; set; }
        //public int rating { get; set; }
    
    }
}