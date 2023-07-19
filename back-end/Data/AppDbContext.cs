using Microsoft.EntityFrameworkCore;
using Ecomerce.Models;

namespace Ecomerce.Data
{
  public class AppDbContext : DbContext
  {
    public DbSet<Product> Products { get; set; }
    public DbSet<ShoppingCar> ShoppingCar { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Shopping> Shoppings { get; set; }
    public DbSet<Delivery> Deliveries { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlite("DataSource=app.db;Cache=Shared");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<User>()
        .HasOne(u => u.ShoppingCar)
        .WithOne(s => s.User)
        .HasForeignKey<ShoppingCar>(s => s.UserId)
        .OnDelete(DeleteBehavior.Cascade);

      modelBuilder.Entity<User>()
          .HasMany(uc => uc.Shopping)
          .WithOne(sp => sp.User)
          .HasForeignKey(sp => sp.UserId);

      modelBuilder.Entity<Delivery>()
        .HasOne(d => d.Sale)
        .WithOne(s => s.Delivery)
        .HasForeignKey<Delivery>(d => d.ShoppingId)
        .IsRequired();

      modelBuilder.Entity<User>()
        .HasIndex(u => u.Email)
        .IsUnique();

    }
  }
}
