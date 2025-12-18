using System;
namespace EventManagementSystem.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; }
        public int Capacity { get; set; }

    }
}
