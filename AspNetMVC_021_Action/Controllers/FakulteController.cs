using AspNetMVC_021_Action.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMVC_021_Action.Controllers
{
    public class FakulteController : Controller
    {
        OBSContext veritabani = new OBSContext();



        public ActionResult Ekle()
        {
            return View();
        }
    }
}