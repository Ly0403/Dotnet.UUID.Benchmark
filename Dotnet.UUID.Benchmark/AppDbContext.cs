using Microsoft.EntityFrameworkCore;

namespace Dotnet.UUID.Benchmark;

public sealed class AppDbContext : DbContext
{
    public DbSet<SimpleInt> SimpleInt { get; set; }
    public DbSet<Guidv4> Guidv4 { get; set; }
    public DbSet<Guidv7> Guidv7 { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=uuid.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<SimpleInt>(builder =>
        {
            builder.HasKey(x => x.Id);
        });

        modelBuilder.Entity<Guidv4>(builder =>
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();
        }); 
        
        modelBuilder.Entity<Guidv7>(builder =>
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();
        });
    }
}
