using KinoSuite.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KinoSuite.Controllers
{
    public class HomeController : Controller
    {
        


        public ActionResult Index()
        {
            var context = new KinoContext();
            var movies = context.Movies;

            var queryResults =
                (from mov in context.Movies
                join screen in context.Screenings on mov.ID equals screen.MovieId
                select new UpcomingScreening {
                    Title = mov.Title,
                    genre = mov.Genre,
                    Image = "implement images, dipshit",
                    language = screen.SubtitleLanguage,
                }).ToList();
                var viewModel = new UpcomingScreeningsViewModel();
                viewModel.ScreeningItems = queryResults;

            return View(viewModel);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}

//            using (var ctx = new KinoContext())
//            {
//                Movie movie = new Movie() { Title = "testmovie", ID = 1, ReleaseDate = DateTime.Now, Genre = "action", Rating = 2, Description = "potatofilm", YouTubeLink = "link", Screenings = null };
//ctx.Movies.Add(movie);
//                ctx.SaveChanges();

//                var query = from test in ctx.Movies
//                            orderby test.Title
//                            select test;

//                foreach (var item in query)
//                {
//                    ViewBag.Items += item.Title;
//                }
//            }