using Microsoft.AspNetCore.Mvc;
using EventManagementSystem.Models;
using System.Collections.Generic;

namespace EventManagementSystem.Controllers
{
    public class EventController : Controller
    {
        // Shared in-memory list (temporary, no database yet)
        private static List<Event> events = new List<Event>
        {
            new Event { Id = 1, Name = "Tech Conference", Location = "Johannesburg", Capacity = 100 },
            new Event { Id = 2, Name = "Business Workshop", Location = "Pretoria", Capacity = 50 }
        };

        // READ
        public IActionResult Index()
        {
            return View(events);
        }
        public IActionResult Edit(int id)
        {
            var ev = events.Find(e => e.Id == id);
            return View(ev);
        }
        [HttpPost]
        public IActionResult Edit(Event ev)
        {
            var existingEvent = events.Find(e => e.Id == ev.Id);

            if (existingEvent != null)
            {
                existingEvent.Name = ev.Name;
                existingEvent.Location = ev.Location;
                existingEvent.Capacity = ev.Capacity;
            }

            return RedirectToAction("Index");
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
            ev.Id = events.Count + 1;
            events.Add(ev);

            return RedirectToAction("Index");
        }
    }
}



