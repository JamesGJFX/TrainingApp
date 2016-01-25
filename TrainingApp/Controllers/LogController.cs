using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrainingApp.DAL;

namespace TrainingApp.Controllers
{
    public class LogController : Controller
    {
        public LogContext db = new LogContext();

        public ActionResult Index()
        {
            return View(db.Logs.ToList());
        }


    }
}