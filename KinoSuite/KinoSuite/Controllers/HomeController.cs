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
            //var viewModel =
            //        from pd in db.ProjectsData
            //        join p in db.Projects on pd.ProjectId equals p.ID
            //        where pd.UserName == this.HttpContext.User.Identity.Name
            //        orderby p.Name, p.ProjectNo
            //        select new MyViewModel { ProjectData = pd, Project = p };

            var context = new KinoContext();
            //var model1 = new UpcomingScreeningsViewModel();

            var screenings = context.Screenings;
            var movies = context.Movies;

            var model = new UpcomingScreeningsViewModel()
            {
                Movies = movies,
                Screenings = screenings,
            };
            //model1 = from screenings in context.Screenings
            //         join movie in context.Movies on screenings.MovieId equals movie.ID
            //         select new UpcomingScreeningsViewModel { Screenings = screenings, Movies = movie };


            //model1.Screenings = context.Screenings;
            //model1.Movies = ;




            return View(model);
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