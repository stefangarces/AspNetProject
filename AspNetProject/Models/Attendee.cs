﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetProject.Models
{
    public class Attendee
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public ICollection<AttendeeEvent> AttendeeEvents { get; set; }
    }
}
