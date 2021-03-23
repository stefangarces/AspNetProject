using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetProject.Models
{
    public class Organizer
    {
        public int ID { get; set; }
        [Required]
        public string OrgName { get; set; }
        public string OrgMail { get; set; }
        public string OrgPhoneNumber { get; set; }
        public ICollection<Event> Events { get; set; }
    }
}
