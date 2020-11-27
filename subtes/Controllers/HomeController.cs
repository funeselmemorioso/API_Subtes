using subtes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace subtes.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            //Root data = TraerDatos();
            return View();
        }

        [HttpGet]
        public ActionResult BuscarData()
        {
            Root data = TraerDatos();
            return Json(data, JsonRequestBehavior.AllowGet);
        }       
    }
}