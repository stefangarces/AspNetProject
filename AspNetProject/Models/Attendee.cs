﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetProject.Models
{
    public class Attendee
    {
        public int ID { get; set; }
        [Required]
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public ICollection<AttendeeEvent> AttendeeEvents { get; set; }
    }
}