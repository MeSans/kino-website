using KinoSuite.Models;
using System.Web.Mvc;

namespace ContosoUniversity.Controllers
{
    public class FileController : Controller
    {
        private KinoSuite.KinoContext db = new KinoSuite.KinoContext();
        //
        // GET: /File/
        public ActionResult Index(int id)
        {
            var fileToRetrieve = db.Files.Find(id);
            return File(fileToRetrieve.Content, fileToRetrieve.ContentType);
        }
    }
}