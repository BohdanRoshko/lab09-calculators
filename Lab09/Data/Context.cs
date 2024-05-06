using Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Data;

public class Context : DbContext
{
    public Context(DbContextOptions<Context> options) : base(options)
    {
    }

    public DbSet<Operation> Operations { get; set; }

    // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    // {
    //     optionsBuilder.UseMySql(connectionString: "", serverVersion: new MySqlServerVersion(new Version(8, 0, 37)));
    // }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Operation>().HasKey(op => op.Id); // Assuming 'Name' is unique and can be used as a key
        base.OnModelCreating(modelBuilder);
    }
}