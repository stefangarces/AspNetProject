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
    public class DeleteModel : PageModel
    {
        private readonly AspNetProject.Data.AspNetProjectContext _context;

        public DeleteModel(AspNetProject.Data.AspNetProjectContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Attendee Attendee { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Attendee = await _context.Attendee.FirstOrDefaultAsync(m => m.ID == id);

            if (Attendee == null)
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

            Attendee = await _context.Attendee.FindAsync(id);

            if (Attendee != null)
            {
                _context.Attendee.Remove(Attendee);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
