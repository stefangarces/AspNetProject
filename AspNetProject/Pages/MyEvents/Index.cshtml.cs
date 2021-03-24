using AspNetProject.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
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

        public IList<Event> Event { get; set; }

        public async Task OnGetAsync()
        {
            Event = await _context.Event.ToListAsync();
        }
    }
}
