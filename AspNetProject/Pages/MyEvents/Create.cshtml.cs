using AspNetProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetProject.Pages.MyEvents
{
    public class CreateModel : PageModel
    {
        private readonly AspNetProject.Data.AspNetProjectContext _context;

        public CreateModel(AspNetProject.Data.AspNetProjectContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            AttendeeEvent joinedEvent = new AttendeeEvent()
            {
                Attendee = await _context.Attendee.Where(a => a.ID == 8675).FirstOrDefaultAsync(),
                Event = await _context.Event.Where(e => e.ID == id).FirstOrDefaultAsync()
            };
            _context.AttendeeEvents.Add(joinedEvent);
            await _context.SaveChangesAsync();

            return RedirectToPage("../Events/Details", new { id });
        }

        [BindProperty]
        public Event Event { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Event.Add(Event);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
