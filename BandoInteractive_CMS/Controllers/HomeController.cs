using BandoInteractive_CMS.Service.Services;
using System.Web.Mvc;

namespace BandoInteractive_CMS.Controllers
{
    public class HomeController : Controller
    {
        PageServices pageServices;

        public HomeController()
        {
            pageServices = new PageServices();
        }

        [HttpGet]
        public ActionResult Index(string pageURL)
        {
            if (!pageURL.StartsWith("/"))
                pageURL = "/" + pageURL;

            var page = pageServices.GetByURL(pageURL);

            if (page == null)
                return HttpNotFound();

            var childs = pageServices.GetChildsById(page.Id);
            page.ChildPages = childs;

            return View(page);
        }
    }
}