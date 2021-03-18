using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AspNetProject.Models;

namespace AspNetProject.Data
{
    public class AspNetProjectContext : DbContext
    {
        public AspNetProjectContext (DbContextOptions<AspNetProjectContext> options)
            : base(options)
        {
        }

        public DbSet<AspNetProject.Models.Event> Event { get; set; }
        public DbSet<AspNetProject.Models.Attendee> Attendee { get; set; }
        public DbSet<AspNetProject.Models.Organizer> Organizer { get; set; }
    }
}
