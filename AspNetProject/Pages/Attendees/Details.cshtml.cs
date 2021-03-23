using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AspNetProject.Data;
using AspNetProject.Models;

namespace AspNetProject.Pages.Attendees
{
    public class DetailsModel : PageModel
    {
        private readonly AspNetProject.Data.AspNetProjectContext _context;

        public DetailsModel(AspNetProject.Data.AspNetProjectContext context)
        {
            _context = context;
        }

        public Attendee Attendee { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Attendee = await _context.Attendee.Include(a => a.AttendeeEvents).FirstOrDefaultAsync(m => m.ID == id);

            if (Attendee == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
