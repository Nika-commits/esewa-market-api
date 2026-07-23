using esewa_market.Data.Entities;
using esewa_market.Data.Enums;
using Microsoft.EntityFrameworkCore;


namespace esewa_market.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Product>().ComplexCollection(p => p.Colors, p => p.ToJson());
    }
}