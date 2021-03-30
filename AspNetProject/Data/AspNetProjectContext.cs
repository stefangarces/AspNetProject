using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AspNetProject.Data
{
    public class AspNetProjectContext : IdentityDbContext
    {
        public AspNetProjectContext(DbContextOptions<AspNetProjectContext> options)
            : base(options)
        {
        }

        public DbSet<AspNetProject.Models.Event> Event { get; set; }
        public DbSet<AspNetProject.Models.Attendee> Attendee { get; set; }
        public DbSet<AspNetProject.Models.Organizer> Organizer { get; set; }
        public DbSet<AspNetProject.Models.AttendeeEvent> AttendeeEvents { get; set; }
    }
}
