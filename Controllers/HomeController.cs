using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace umuly_case_sn.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Teklifler()
        {
            ViewBag.Message = "yapılan teklifler";

            return View();
        }

       
    }
}