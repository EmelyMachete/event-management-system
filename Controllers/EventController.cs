using Microsoft.AspNetCore.Mvc;
using EventManagementSystem.Models;
using System.Collections.Generic;
using System.Linq;

namespace EventManagementSystem.Controllers
{
    public class EventController : Controller
    {
        // Temporary in-memory data store (will be replaced by database)
        private static List<Event> _events = new List<Event>
        {
            new Event { Id = 1, Name = "Tech Conference", Location = "Johannesburg", Capacity = 100 },
            new Event { Id = 2, Name = "Business Workshop", Location = "Pretoria", Capacity = 50 }
        };

        // READ: List all events
        public IActionResult Index()
        {
            return View(_events);
        }

        // CREATE: Show form
        public IActionResult Create()
        {
            return View();
        }

        // CREATE: Handle form submission
        [HttpPost]
        public IActionResult Create(Event ev)
        {
            ev.Id = _events.Count > 0 ? _events.Max(e => e.Id) + 1 : 1;
            _events.Add(ev);

            return RedirectToAction(nameof(Index));
        }

        // EDIT: Show edit form
        public IActionResult Edit(int id)
        {
            var ev = _events.FirstOrDefault(e => e.Id == id);
            return View(ev);
        }

        // EDIT: Handle edit submission
        [HttpPost]
        public IActionResult Edit(Event ev)
        {
            var existingEvent = _events.FirstOrDefault(e => e.Id == ev.Id);

            if (existingEvent != null)
            {
                existingEvent.Name = ev.Name;
                existingEvent.Location = ev.Location;
                existingEvent.Capacity = ev.Capacity;
            }

            return RedirectToAction(nameof(Index));
        }

        // DELETE: Remove event
        public IActionResult Delete(int id)
        {
            var ev = _events.FirstOrDefault(e => e.Id == id);

            if (ev != null)
            {
                _events.Remove(ev);
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
