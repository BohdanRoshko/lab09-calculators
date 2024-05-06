using Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Operation> Operations { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Operation>().HasKey(op => op.Id); // Assuming 'Name' is unique and can be used as a key
        base.OnModelCreating(modelBuilder);
    }
}