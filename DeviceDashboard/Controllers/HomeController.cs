using DeviceDashboard.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DeviceDashboard.Controllers
{
    public class HomeController : Controller
    {
        DeviceDashboardDb _db = new DeviceDashboardDb();

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(DeviceConfig dc)
        {
            if (ModelState.IsValid)
            {
                _db.DeviceConfigs.Add(dc);
                _db.SaveChanges();
                return RedirectToAction("Create");
            }

            return View(dc); 
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

        protected override void Dispose(bool disposing)
        {
            if(_db != null)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}