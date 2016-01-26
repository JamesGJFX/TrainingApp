using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrainingApp.DAL;
using TrainingApp.Models;

namespace TrainingApp.Controllers
{
    public class LogController : Controller
    {
        public LogContext db = new LogContext();

        public ActionResult Index()
        {
            return View(db.Logs.ToList());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Log log)
        {
            if (ModelState.IsValid)
            {
                log.Date = DateTime.Today;
                db.Logs.Add(log);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(log);
        }
    }
}