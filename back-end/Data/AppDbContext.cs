using Microsoft.EntityFrameworkCore;
using Ecomerce.Models;
using Ecomerce.Models.UserProperties;
using Ecomerce.Models.UserProperties.UserCustomerProperties;

namespace Ecomerce.Data
{
  public class AppDbContext : DbContext
  {
    public DbSet<Product> Products { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<UserSeller> UserSellers { get; set; }
    public DbSet<UserCustomer> UserCustomers { get; set; }
    public DbSet<ShoppingCar> ShoppingCars { get; set; }
    public DbSet<Operation> Operations { get; set; }
    public DbSet<Delivery> Deliveries { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlite("DataSource=app.db;Cache=Shared");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<User>()
        .HasOne(u => u.UserSeller)
        .WithOne(s => s.User)
        .HasForeignKey<UserSeller>(s => s.UserId)
        .OnDelete(DeleteBehavior.Cascade);

      modelBuilder.Entity<User>()
          .HasOne(uc => uc.UserCustomer)
          .WithOne(sp => sp.User)
          .HasForeignKey<UserCustomer>(sp => sp.UserId);

      modelBuilder.Entity<UserSeller>()
        .HasMany(d => d.Operations)
        .WithOne(s => s.UserSeller)
        .HasForeignKey(s => s.UserSellerId);

      modelBuilder.Entity<UserSeller>()
        .HasMany(p => p.Products)
        .WithOne(s => s.UserSeller)
        .HasForeignKey(s => s.UserSellerId);

      modelBuilder.Entity<UserCustomer>()
        .HasOne(s => s.ShoppingCar)
        .WithOne(s => s.UserCustomer)
        .HasForeignKey<ShoppingCar>(s => s.UserCustomerId);

      modelBuilder.Entity<UserCustomer>()
        .HasMany(s => s.Shopping)
        .WithOne(s => s.UserCustomer)
        .HasForeignKey(s => s.UserCustomerId);

      modelBuilder.Entity<User>()
        .HasIndex(u => u.Email)
        .IsUnique();

    }
  }
}
