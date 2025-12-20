using Microsoft.AspNetCore.Mvc;
using EventManagementSystem.Models;
using System.Linq;

namespace EventManagementSystem.Controllers
{
    public class EventController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EventController(ApplicationDbContext context)
        {
            _context = context;
        }

        // READ
        public IActionResult Index()
        {
            var events = _context.Events.ToList();
            return View(events);
        }

        // CREATE (GET)
        public IActionResult Create()
        {
            return View();
        }

        // CREATE (POST)
        [HttpPost]
        public IActionResult Create(Event ev)
        {
            if (ModelState.IsValid)
            {
                _context.Events.Add(ev);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ev);
        }

        // EDIT (GET)
        public IActionResult Edit(int id)
        {
            var ev = _context.Events.Find(id);
            return View(ev);
        }

        // EDIT (POST)
        [HttpPost]
        public IActionResult Edit(Event ev)
        {
            if (ModelState.IsValid)
            {
                _context.Events.Update(ev);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ev);
        }

        // DELETE
        public IActionResult Delete(int id)
        {
            var ev = _context.Events.Find(id);

            if (ev != null)
            {
                _context.Events.Remove(ev);
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}
