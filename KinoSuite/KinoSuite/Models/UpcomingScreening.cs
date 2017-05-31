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
            this.screening = new Screening();
            this.Movie = new Movie();            
        }
        public Screening screening { get; set; }
        public Movie Movie { get; set; }

    }
}