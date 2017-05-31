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
            this.Image = "PLACEHOLDER. CHANGE THIS TO IMAGE";
            this.Title = "";
            this.genre = "";
            this.startTime = DateTime.MinValue;
            this.length = "";
            this.language = "";
            this.subtitleLanguage = "";
            this.isPremiere = false;


        }
        public string Image { get; set; }
        public string Title { get; set; }
        public string genre { get; set; }
        public DateTime? startTime { get; set; }
        public string length { get; set; }
        public string language { get; set; }
        public string subtitleLanguage { get; set; }
        public bool isPremiere { get; set; }
    
    }
}