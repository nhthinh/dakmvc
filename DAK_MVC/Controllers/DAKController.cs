using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DAK_MVC.Controllers
{
    public class DAKController : Controller
    {
        // GET: DAK
        public ActionResult homepage()
        {
            return View("homepage");
        }
    }
}