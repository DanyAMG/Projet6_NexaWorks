using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using Projet6_NexaWorks.Models;

namespace Projet6_NexaWorks.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        //entities
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductVersion> ProductVersions { get; set; }
        public DbSet<AppOperatingSystem> AppOperatingSystems { get; set; }
        public DbSet<TicketProductOperatingSystem> TicketProductOperatingSystems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TicketProductOperatingSystem>()
                .HasKey(to => new { to.TicketId, to.AppOperatingSystemId });
            base.OnModelCreating(modelBuilder);
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

    }
}
