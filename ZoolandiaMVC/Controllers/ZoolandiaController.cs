using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ZoolandiaMVC.Controllers
{
    public class ZoolandiaController : Controller
    {
        // GET: Zoolandia
        public ActionResult Index()
        {
            return View();
        }
    }
}