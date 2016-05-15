using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using ZoolandiaMVC.Models;

namespace ZoolandiaMVC.Controllers
{
    public class GenusController : Controller
    {
        private ApplicationDbContext _context;

        public GenusController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Genus
        public IActionResult Index()
        {
            return View(_context.Genus.ToList());
        }

        // GET: Genus/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Genus genus = _context.Genus.Single(m => m.ID == id);
            if (genus == null)
            {
                return HttpNotFound();
            }

            return View(genus);
        }

        // GET: Genus/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Genus/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Genus genus)
        {
            if (ModelState.IsValid)
            {
                _context.Genus.Add(genus);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(genus);
        }

        // GET: Genus/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Genus genus = _context.Genus.Single(m => m.ID == id);
            if (genus == null)
            {
                return HttpNotFound();
            }
            return View(genus);
        }

        // POST: Genus/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Genus genus)
        {
            if (ModelState.IsValid)
            {
                _context.Update(genus);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(genus);
        }

        // GET: Genus/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Genus genus = _context.Genus.Single(m => m.ID == id);
            if (genus == null)
            {
                return HttpNotFound();
            }

            return View(genus);
        }

        // POST: Genus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            Genus genus = _context.Genus.Single(m => m.ID == id);
            _context.Genus.Remove(genus);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
