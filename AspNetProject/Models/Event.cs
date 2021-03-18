using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetProject.Models
{
    public class Event
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Place { get; set; }
        public string Adress { get; set; }
        public DateTime Date { get; set; }
        public bool TicketsAvailable { get; set; }
        public Organizer Organizer { get; set; }
        public ICollection<Attendee> Attendees { get; set; }
    }
}