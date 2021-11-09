using Cajerojuly.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cajerojuly.Controllers
{
    public class CajeroSController : Controller
    {

        // GET: Cajero
     

            [HttpPost]
            public ActionResult IndexC(Cajero c)
            {

            if (c.Monto % 5 == 0)
            {
                return Redirect("Correcto");
            }
            else
            {
                return Redirect("Errorr");
            }

            }

            [HttpGet]
            public ActionResult Index()
            {
                return View();
            }

            [HttpGet]
            public ActionResult Errorr()
            {
                return View();
            }

            [HttpGet]
            public ActionResult Correcto()
            {
                return View();
            }
        
    }
}
