using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using ZoolandiaMVC.Models;

namespace ZoolandiaMVC.Controllers
{
    public class HabitatTypesController : Controller
    {
        private ApplicationDbContext _context;

        public HabitatTypesController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: HabitatTypes
        public IActionResult Index()
        {
            return View(_context.HabitatType.ToList());
        }

        // GET: HabitatTypes/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            HabitatType habitatType = _context.HabitatType.Single(m => m.ID == id);
            if (habitatType == null)
            {
                return HttpNotFound();
            }

            return View(habitatType);
        }

        // GET: HabitatTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: HabitatTypes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(HabitatType habitatType)
        {
            if (ModelState.IsValid)
            {
                _context.HabitatType.Add(habitatType);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(habitatType);
        }

        // GET: HabitatTypes/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            HabitatType habitatType = _context.HabitatType.Single(m => m.ID == id);
            if (habitatType == null)
            {
                return HttpNotFound();
            }
            return View(habitatType);
        }

        // POST: HabitatTypes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(HabitatType habitatType)
        {
            if (ModelState.IsValid)
            {
                _context.Update(habitatType);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(habitatType);
        }

        // GET: HabitatTypes/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            HabitatType habitatType = _context.HabitatType.Single(m => m.ID == id);
            if (habitatType == null)
            {
                return HttpNotFound();
            }

            return View(habitatType);
        }

        // POST: HabitatTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            HabitatType habitatType = _context.HabitatType.Single(m => m.ID == id);
            _context.HabitatType.Remove(habitatType);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
