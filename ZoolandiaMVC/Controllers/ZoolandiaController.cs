using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZoolandiaMVC.Models;

namespace ZoolandiaMVC.Controllers
{
  public class ZoolandiaController : Controller
  {
    // GET: Zoolandia
    public ActionResult Index()
    {
        return View();
    }

    public ActionResult Animals()
    {
      using (var zoolandiaContext = new ZoolandiaContext())
      {
        List<Animal> animals = zoolandiaContext.Animal.Take(1000).ToList();
        return View(animals);
      }
    }
  }
}