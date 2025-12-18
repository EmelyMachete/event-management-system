using Microsoft.AspNetCore.Mvc;
using EventManagementSystem.Models;
using System.Collections.Generic;

namespace EventManagementSystem.Controllers
{
    public class EventController : Controller
    {
        public IActionResult Index()
        {
            // Temporary List of events (no database yet)
            var events = new List<Event>
            {
                new Event { Id = 1, Name = "Tech Conference", Location = "Johannesburg", Capacity = 100 },
                new Event { Id = 2, Name = "Business Workshop", Location = "Pretoria", Capacity = 50 },
            
            
            };

            return View(events);
        }
}   }

    

