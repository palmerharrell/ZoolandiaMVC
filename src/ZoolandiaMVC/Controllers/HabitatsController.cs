using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using ZoolandiaMVC.Models;

namespace ZoolandiaMVC.Controllers
{
    public class HabitatsController : Controller
    {
        private ApplicationDbContext _context;

        public HabitatsController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Habitats
        public IActionResult Index()
        {
            return View(_context.Habitat.ToList());
        }

        // GET: Habitats/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Habitat habitat = _context.Habitat.Single(m => m.ID == id);
            if (habitat == null)
            {
                return HttpNotFound();
            }

            return View(habitat);
        }

        // GET: Habitats/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Habitats/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Habitat habitat)
        {
            if (ModelState.IsValid)
            {
                _context.Habitat.Add(habitat);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(habitat);
        }

        // GET: Habitats/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Habitat habitat = _context.Habitat.Single(m => m.ID == id);
            if (habitat == null)
            {
                return HttpNotFound();
            }
            return View(habitat);
        }

        // POST: Habitats/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Habitat habitat)
        {
            if (ModelState.IsValid)
            {
                _context.Update(habitat);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(habitat);
        }

        // GET: Habitats/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Habitat habitat = _context.Habitat.Single(m => m.ID == id);
            if (habitat == null)
            {
                return HttpNotFound();
            }

            return View(habitat);
        }

        // POST: Habitats/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            Habitat habitat = _context.Habitat.Single(m => m.ID == id);
            _context.Habitat.Remove(habitat);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
