using KinoSuite.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace KinoSuite.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            var context = new KinoContext();

            var queryResults =
                (from mov in context.Movies
                join screen in context.Screenings on mov.ID equals screen.MovieId
                where (screen.ScreeningStart.Value.Year == System.DateTime.Now.Year & screen.ScreeningStart.Value.Month == System.DateTime.Now.Month)
                select new UpcomingScreening {
                    Title = mov.Title,
                    genre = mov.Genre.Name,
                    Image = mov.Files.FirstOrDefault().Content,
                    language = screen.SubtitleLanguage,
                    Description = mov.Description,
                    length = ((screen.ScreeningEnd.Value.Hour - screen.ScreeningStart.Value.Hour)*60) + (screen.ScreeningEnd.Value.Minute - screen.ScreeningStart.Value.Minute),
                    youtube_link = mov.YouTubeLink,
                    startTime = screen.ScreeningStart.Value,
                    venue = screen.Venue.Name,
                    isPremiere = (bool)screen.IsPremiere
                    
                }).ToList();
                var viewModel = new UpcomingScreeningsViewModel();
                viewModel.ScreeningItems = queryResults;

            return View(viewModel);
        }

        public ActionResult About()
        {
            ViewBag.Title = "Cinema 'Kino' ";
            ViewBag.Message = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi suscipit odio magna, vel blandit nulla semper eu. Etiam laoreet sagittis euismod. In euismod lobortis ultrices. Aliquam erat volutpat. Donec a massa purus. Praesent quis orci justo. Etiam auctor, turpis ut sagittis lobortis, metus ex egestas erat, in interdum ligula urna a tortor. Integer posuere facilisis eros et commodo. Quisque et nulla tincidunt, egestas purus non, aliquet elit. Maecenas volutpat erat et lacus imperdiet, vel hendrerit velit ultricies.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact information";

            return View();
        }
    }
}

