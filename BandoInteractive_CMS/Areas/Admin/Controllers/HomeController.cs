using BandoInteractive_CMS.Service.Services;
using System.Web.Mvc;

namespace BandoInteractive_CMS.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        PageServices pageServices;

        public HomeController()
        {
            pageServices = new PageServices();
        }

        [HttpGet]
        public ActionResult Index()
        {
            var pages = pageServices.GetAll();

            return View(pages);
        }
    }
}