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
        public DbSet<Date> Dates { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductVersion> ProductVersions { get; set; }
        public DbSet<AppOperatingSystem> AppOperatingSystems { get; set; }
        public DbSet<OperatingSystemVersion> OperatingSystemVersions { get; set; }
        public DbSet<TicketOperatingSystem> TicketOperatingSystems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TicketOperatingSystem>()
                .HasKey(to => new { to.TicketId, to.AppOperatingSystemId });
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Ticket>()
                .HasOne(t => t.Product)
                .WithMany()
                .HasForeignKey(t => t.ProductId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Ticket>()
                .HasOne(t => t.ProductVersion)
                .WithMany()
                .HasForeignKey(t => t.ProductVersionId)
                .OnDelete(DeleteBehavior.Restrict);
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

    }
}
