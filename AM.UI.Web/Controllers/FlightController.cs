using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using AM.ApplicationCore.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AM.UI.Web.Controllers
{
    public class FlightController : Controller

    {
        IServiceFlight serviceflight;
        IServicePlane serviceplane;
        public FlightController(IServiceFlight serviceflight,IServicePlane serviceplane)
        {
            this.serviceflight = serviceflight;
            this.serviceplane = serviceplane;
        }
        // GET: FlightController
        public ActionResult Index()
        {
            var flights=serviceflight.GetAll().ToList();
            return View(flights);
        }

        // GET: FlightController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FlightController/Create
        public ActionResult Create()
        {
            ViewBag.Plane = new SelectList(serviceplane.GetAll(), "PlaneId", "Information");
            return View();
        }

        public ActionResult search(string departure, string destination)
        {
            if (departure != null)
            {
                var flights = serviceflight.GetAll().Where(f => f.Departure.Contains(departure));
                return View("index",flights);
            }else
            {
                var flights = serviceflight.GetAll().Where(f => f.Destination.Contains(destination));
                return View("index", flights);
            }
        }

        // POST: FlightController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Flight collection)
        {
            try
            {
                serviceflight.Add(collection);
                serviceflight.Commit();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FlightController/Edit/5
        public ActionResult Edit(int id)
        {
            Flight flight = serviceflight.GetById(id);
            var list = serviceplane.GetAll();
            ViewBag.Planes = new SelectList(list, "PlaneId", "Information");
            return View(flight);
        }

        // POST: FlightController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Flight collection)
        {
            try
            {
                serviceflight.Update(collection);
                serviceflight.Commit();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        

        // GET: HomeController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HomeController1/Delete/5
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
