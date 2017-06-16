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
        public ActionResult Index(string SearchString, DateTime? ScreeningStart, DateTime? ScreeningEnd, DateTime? ReleaseStart, DateTime? ReleaseEnd, int? SelectedGenreID = 0)
        {
            
            var context = new KinoContext();
             

            var queryResults =
                (from mov in context.Movies
                 join screen in context.Screenings on mov.ID equals screen.MovieId //Select movies_screens 
                 where SearchString == null | mov.Title.Contains(SearchString) // Searchstring ==null -> match all if string not inputted
                 where (ScreeningStart ==  null | ScreeningStart <= screen.ScreeningStart) & (ScreeningEnd == null | screen.ScreeningStart <= ScreeningEnd) // Where screeningStart is in selected period
                 where (ReleaseStart == null | ReleaseStart <= mov.ReleaseDate) & (ReleaseEnd == null |  mov.ReleaseDate <= ReleaseEnd) // Where Release is in selected period
                 where SelectedGenreID == 0 | SelectedGenreID == mov.Genre.ID
                 select new UpcomingScreening
                 {
                     Title = mov.Title,
                     genre = mov.Genre.Name,
                     Image = mov.Files.FirstOrDefault().Content,
                     language = screen.Language,
                     subtitleLanguage = screen.SubtitleLanguage,
                     Description = mov.Description,
                     length = ((screen.ScreeningEnd.Value.Hour - screen.ScreeningStart.Value.Hour) * 60) + (screen.ScreeningEnd.Value.Minute - screen.ScreeningStart.Value.Minute),
                     youtube_link = mov.YouTubeLink,
                     startTime = screen.ScreeningStart.Value,
                     venue = screen.Venue.Name,
                     isPremiere = (bool)screen.IsPremiere

                 }).ToList();
            var viewModel = new UpcomingScreeningsViewModel();
            viewModel.ScreeningItems = queryResults;
            ViewBag.SelectedGenreId = new SelectList(context.Genres, "ID", "Name",  SelectedGenreID);
            return View(viewModel);
        }
    }
}