using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using ZoolandiaMVC.Models;

namespace ZoolandiaMVC.Controllers
{
    public class HabitatEmployeesController : Controller
    {
        private ApplicationDbContext _context;

        public HabitatEmployeesController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: HabitatEmployees
        public IActionResult Index()
        {
            return View(_context.HabitatEmployees.ToList());
        }

        // GET: HabitatEmployees/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            HabitatEmployees habitatEmployees = _context.HabitatEmployees.Single(m => m.ID == id);
            if (habitatEmployees == null)
            {
                return HttpNotFound();
            }

            return View(habitatEmployees);
        }

        // GET: HabitatEmployees/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: HabitatEmployees/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(HabitatEmployees habitatEmployees)
        {
            if (ModelState.IsValid)
            {
                _context.HabitatEmployees.Add(habitatEmployees);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(habitatEmployees);
        }

        // GET: HabitatEmployees/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            HabitatEmployees habitatEmployees = _context.HabitatEmployees.Single(m => m.ID == id);
            if (habitatEmployees == null)
            {
                return HttpNotFound();
            }
            return View(habitatEmployees);
        }

        // POST: HabitatEmployees/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(HabitatEmployees habitatEmployees)
        {
            if (ModelState.IsValid)
            {
                _context.Update(habitatEmployees);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(habitatEmployees);
        }

        // GET: HabitatEmployees/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            HabitatEmployees habitatEmployees = _context.HabitatEmployees.Single(m => m.ID == id);
            if (habitatEmployees == null)
            {
                return HttpNotFound();
            }

            return View(habitatEmployees);
        }

        // POST: HabitatEmployees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            HabitatEmployees habitatEmployees = _context.HabitatEmployees.Single(m => m.ID == id);
            _context.HabitatEmployees.Remove(habitatEmployees);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
