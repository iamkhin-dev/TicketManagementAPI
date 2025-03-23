using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace TicketManagementAPI.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Ticket> Tickets { get; set; }
    }
}
