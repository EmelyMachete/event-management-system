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



