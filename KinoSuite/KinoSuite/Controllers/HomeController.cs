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
            //using (var ctx = new KinoContext())
            //{
            //    Movie movie = new Movie() { Title = "testmovie", ID = 1, ReleaseDate = DateTime.Now, Genre="action", Rating = 2, Description = "potatofilm", YouTubeLink = "link",Screenings=null};
            //    ctx.Movies.Add(movie);
            //    ctx.SaveChanges();

            //    var query = from test in ctx.Movies
            //                orderby test.Title
            //                select test;

            //    foreach (var item in query)
            //    {
            //        ViewBag.Items += item.Title;
            //    }
            //}
            return View();
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