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
    public class IndexModel : PageModel
    {
        private readonly AspNetProject.Data.AspNetProjectContext _context;

        public IndexModel(AspNetProject.Data.AspNetProjectContext context)
        {
            _context = context;
        }

        public IList<Attendee> Attendee { get;set; }

        public async Task OnGetAsync()
        {
            Attendee = await _context.Attendee.ToListAsync();
        }
    }
}
