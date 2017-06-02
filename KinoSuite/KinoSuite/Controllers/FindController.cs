using KinoSuite.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KinoSuite.Controllers
{
    public class FindController : Controller
    {
        // GET: Find
        public ActionResult Index(string SearchString, DateTime? ScreeningStart, DateTime? ScreeningEnd, DateTime? ReleaseStart, DateTime? ReleaseEnd, int? SelectedGenre)
        {
            
            var context = new KinoContext();
             

            var queryResults =
                (from mov in context.Movies
                 join screen in context.Screenings on mov.ID equals screen.MovieId //Select movies_screens 
                 where SearchString == null | mov.Title.Contains(SearchString) // Searchstring ==null -> match all if string not inputted
                 where (ScreeningStart ==  null | ScreeningStart <= screen.ScreeningStart) & (ScreeningEnd == null | screen.ScreeningStart <= ScreeningEnd) // Where screeningStart is in selected period
                 where (ReleaseStart == null | ReleaseStart <= mov.ReleaseDate) & (ReleaseEnd == null |  mov.ReleaseDate <= ReleaseEnd) // Where Release is in selected period
                 
                 select new UpcomingScreening
                 {
                     Title = mov.Title,
                     genre = SelectedGenre.ToString(),
                     Image = mov.Files.FirstOrDefault().Content,
                     language = screen.SubtitleLanguage,
                     Description = mov.Description,
                     length = DbFunctions.DiffMinutes(screen.ScreeningEnd, screen.ScreeningStart),
                     youtube_link = mov.YouTubeLink,
                     startTime = screen.ScreeningStart,
                     venue = screen.Venue.Name

                 }).ToList();
            var viewModel = new UpcomingScreeningsViewModel();
            viewModel.ScreeningItems = queryResults;
            viewModel.Genres = context.Genres;
       /*        Select(c => new SelectListItem
               {
                   Value = c.DropDownID.ToString(),
                   Text = c.DropDownText
               });
            viewModel.Genres = (from genr in context.Genres select genr.Name).ToList();
            */
            return View(viewModel);
        }
    }
}