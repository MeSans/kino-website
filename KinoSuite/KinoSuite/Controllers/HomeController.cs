using KinoSuite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KinoSuite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (var ctx = new KinoContext())
            {
                Movie movie = new Movie() { Name = "test movie" };

                ctx.Movies.Add(movie);
                ctx.SaveChanges();

                var query = from test in ctx.Movies
                            orderby test.Name
                            select test;

                foreach (var item in query)
                {
                    ViewBag.Items += item.Name;
                }
            }
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