﻿
using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using AM.ApplicationCore.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AM.UI.Web.Controllers
{
    public class PlaneController : Controller
    {
        IServicePlane serviceplane;
        public PlaneController(IServicePlane serviceplane)
        {
            this.serviceplane = serviceplane;
        }
        // GET: PlaneController
        public ActionResult Index()
        {
            var planes = serviceplane.GetAll().ToList();
            return View(planes);
        }

        // GET: PlaneController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PlaneController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PlaneController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Plane collection)
        {
            try
            {
                serviceplane.Add(collection);
                serviceplane.Commit();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PlaneController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PlaneController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PlaneController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PlaneController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
