using System.Web.Mvc;

namespace MtDaraitanSite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(); // Views/Home/Index.cshtml
        }

        public ActionResult About()
        {
            return View(); // Views/Home/About.cshtml
        }

        public ActionResult Gallery()
        {
            return View(); // Views/Home/Gallery.cshtml
        }
    }
}
