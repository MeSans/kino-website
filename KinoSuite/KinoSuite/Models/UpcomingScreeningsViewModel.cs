using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

using KinoSuite.Models;
using System.Web.Mvc;

namespace KinoSuite.Models
{
    public class UpcomingScreeningsViewModel
    {
        public UpcomingScreeningsViewModel()
        {
            this.ScreeningItems = new List<UpcomingScreening>();
        }
        public List<Models.UpcomingScreening> ScreeningItems;

    }
}