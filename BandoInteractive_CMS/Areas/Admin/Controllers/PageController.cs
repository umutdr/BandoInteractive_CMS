using BandoInteractive_CMS.Entity.Entities;
using BandoInteractive_CMS.Service.Services;
using System.Net;
using System.Web.Mvc;

namespace BandoInteractive_CMS.Areas.Admin.Controllers
{
    public class PageController : Controller
    {
        PageServices pageServices;
        LayoutServices layoutServices;

        public PageController()
        {
            pageServices = new PageServices();
            layoutServices = new LayoutServices();
        }

        [HttpGet]
        public ActionResult Index()
        {
            var pageList = pageServices.GetAll();

            return View(pageList);
        }

        [HttpGet]
        public ActionResult Details(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            Page page = pageServices.GetById(id);

            if (page == null)
                return HttpNotFound();

            return View(page);
        }

        [HttpGet]
        public ActionResult Create()
        {
            LayoutServices layoutServices = new LayoutServices();

            var layouts = layoutServices.GetAll();
            var pages = pageServices.GetAll();

            ViewBag.LayoutId = new SelectList(layouts, "Id", "Name");
            ViewBag.ParentPageId = new SelectList(pages, "Id", "Name");

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Content,URL,LayoutId,ParentPageId")] Page page)
        {
            if (!ModelState.IsValid)
            {
                var layouts = layoutServices.GetAll();
                var pages = pageServices.GetAll();

                ViewBag.LayoutId = new SelectList(layouts, "Id", "Name");
                ViewBag.ParentPageId = new SelectList(pages, "Id", "Name");

                return View(page);
            }

            pageServices.Create(page);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            Page page = pageServices.GetById(id);

            if (page == null)
                return HttpNotFound();

            var layouts = layoutServices.GetAll();
            var pages = pageServices.GetAll();

            ViewBag.LayoutId = new SelectList(layouts, "Id", "Name");
            ViewBag.ParentPageId = new SelectList(pages, "Id", "Name");

            return View(page);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Content,URL,LayoutId,ParentPageId")] Page page)
        {
            if (!ModelState.IsValid)
            {
                var layouts = layoutServices.GetAll();
                var pages = pageServices.GetAll();

                ViewBag.LayoutId = new SelectList(layouts, "Id", "Name");
                ViewBag.ParentPageId = new SelectList(pages, "Id", "Name");

                return View(page);
            }

            pageServices.Update(page);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            Page page = pageServices.GetById(id);

            if (page == null)
                return HttpNotFound();

            return View(page);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Page page = pageServices.GetById(id);

            pageServices.Delete(page);

            return RedirectToAction("Index");
        }

    }
}