using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using ZoolandiaMVC.Models;

namespace ZoolandiaMVC.Controllers
{
    public class SpeciesController : Controller
    {
        private ApplicationDbContext _context;

        public SpeciesController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Species
        public IActionResult Index()
        {
            return View(_context.Species.ToList());
        }

        // GET: Species/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Species species = _context.Species.Single(m => m.ID == id);
            if (species == null)
            {
                return HttpNotFound();
            }

            return View(species);
        }

        // GET: Species/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Species/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Species species)
        {
            if (ModelState.IsValid)
            {
                _context.Species.Add(species);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(species);
        }

        // GET: Species/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Species species = _context.Species.Single(m => m.ID == id);
            if (species == null)
            {
                return HttpNotFound();
            }
            return View(species);
        }

        // POST: Species/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Species species)
        {
            if (ModelState.IsValid)
            {
                _context.Update(species);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(species);
        }

        // GET: Species/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Species species = _context.Species.Single(m => m.ID == id);
            if (species == null)
            {
                return HttpNotFound();
            }

            return View(species);
        }

        // POST: Species/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            Species species = _context.Species.Single(m => m.ID == id);
            _context.Species.Remove(species);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
