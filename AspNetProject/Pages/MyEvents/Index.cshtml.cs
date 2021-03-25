using AspNetProject.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetProject.Pages.MyEvents
{
    public class IndexModel : PageModel
    {
        private readonly AspNetProject.Data.AspNetProjectContext _context;

        public IndexModel(AspNetProject.Data.AspNetProjectContext context)
        {
            _context = context;
        }

        public IList<AttendeeEvent> AttendeeEvent { get; set; }

        public async Task OnGetAsync()
        {
            AttendeeEvent = await _context.AttendeeEvents.Include(e => e.Event).Where(a => a.Attendee.ID == 8675).ToListAsync();
        }
    }
}
