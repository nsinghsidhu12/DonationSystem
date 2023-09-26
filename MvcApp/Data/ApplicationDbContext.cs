using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ClassLibDb.Models;

namespace MvcApp.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<TransactionType> TransactionTypes { get; set; }

    public DbSet<PaymentMethod> PaymentMethods { get; set; }
    public DbSet<Donation> Donations { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Contact>().ToTable("Contact");
            builder.Entity<TransactionType>().ToTable("TransactionType");
            builder.Entity<PaymentMethod>().ToTable("PaymentMethod");
            builder.Entity<Donation>().ToTable("Donation");

            builder.Seed();
        }
}
