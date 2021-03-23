﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AspNetProject.Data;
using AspNetProject.Models;

namespace AspNetProject.Pages.Events
{
    public class DetailsModel : PageModel
    {
        private readonly AspNetProject.Data.AspNetProjectContext _context;

        public DetailsModel(AspNetProject.Data.AspNetProjectContext context)
        {
            _context = context;
        }

        public Event Event { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Event = await _context.Event.FirstOrDefaultAsync(m => m.ID == id);

            if (Event == null)
            {
                return NotFound();
            }
            return Page();
        }
        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Attendee GrabsAtEvents = await _context.Attendee.FirstOrDefaultAsync();
            Event = await _context.Event.FirstOrDefaultAsync(m => m.ID == id);
            GrabsAtEvents.Events.ToList().Add(Event);
            _context.SaveChanges();

            if (Event == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
