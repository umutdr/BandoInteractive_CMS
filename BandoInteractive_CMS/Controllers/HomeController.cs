using System.Web.Mvc;

namespace BandoInteractive_CMS.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
    }
}