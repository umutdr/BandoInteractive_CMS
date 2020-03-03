using BandoInteractive_CMS.Entity.Entities;
using BandoInteractive_CMS.Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace BandoInteractive_CMS.Areas.Admin.Controllers
{
    public class LayoutController : Controller
    {
        private LayoutServices layoutServices;

        public LayoutController()
        {
            layoutServices = new LayoutServices();
        }

        [HttpGet]
        public ActionResult Index()
        {
            List<Layout> layoutList = layoutServices.GetAll();

            return View(layoutList);
        }

        [HttpGet]
        public ActionResult Details(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            Layout layout = layoutServices.GetById(id);

            if (layout == null)
                return HttpNotFound();

            return View(layout);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Path")] Layout layout)
        {
            if (!ModelState.IsValid)
                return View(layout);

            layoutServices.Create(layout);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            Layout layout = layoutServices.GetById(id);

            if (layout == null)
                return HttpNotFound();

            return View(layout);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Path")] Layout layout)
        {
            if (!ModelState.IsValid)
                return View(layout);

            layoutServices.Update(layout);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            Layout layout = layoutServices.GetById(id);

            if (layout == null)
                return HttpNotFound();

            return View(layout);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Layout layout = layoutServices.GetById(id);
            layoutServices.Delete(layout);
            
            return RedirectToAction("Index");
        }

    }
}