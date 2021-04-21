using AspNetProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

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
        public bool IsJoined { get; set; } = false;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Event = await _context.Event.FirstOrDefaultAsync(m => m.ID == id);
            AttendeeEvent AttendeeEvent = await _context.AttendeeEvents.Where(ae => ae.Attendee.ID == 8675 && ae.Event.ID == id).FirstOrDefaultAsync();

            if (AttendeeEvent != default)
            {
                IsJoined = true;
            }

            if (Event == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
