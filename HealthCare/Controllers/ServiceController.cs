using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HealthCare.Controllers
{
    public class ServiceController : Controller
    {
        // GET: Service
        public ActionResult Index()
        {
            return View();
        }

        //GET: Domiciliary
        public ActionResult Domiciliary()
        {
            return View();
        }

        public ActionResult SupportedLiving()
        {
            return View();
        }

        public ActionResult LiveInCare()
        {
            return View();
        }

        public ActionResult Companionship()
        {
            return View();
        }

        public ActionResult HomeFromHospital()
        {
            return View();
        }

        public ActionResult PersonalCare()
        {
            return View();
        }
    }
}