using Microsoft.EntityFrameworkCore;
using Ecomerce.Models;

namespace Ecomerce.Data
{
  public class AppDbContext : DbContext
  {
    public DbSet<Product> Products { get; set; }
    public DbSet<ShoppingCar> ShoppingCar { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<UserCustomer> UserCustomers { get; set; }
    public DbSet<UserSeller> UserSellers { get; set; }
    public DbSet<SaleProduct> Sales { get; set; }
    public DbSet<Delivery> Deliveries { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlite("DataSource=app.db;Cache=Shared");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<UserCustomer>()
        .HasOne(u => u.ShoppingCar)
        .WithOne(s => s.Customer)
        .HasForeignKey<ShoppingCar>(s => s.CustomerId)
        .OnDelete(DeleteBehavior.Cascade);

      modelBuilder.Entity<UserCustomer>()
          .HasMany(uc => uc.Shopping)
          .WithOne(sp => sp.Customer)
          .HasForeignKey(sp => sp.CustomerId);

      modelBuilder.Entity<UserSeller>()
       .HasMany(uc => uc.Sales)
       .WithOne(sp => sp.Seller)
       .HasForeignKey(sp => sp.SellerId);

      modelBuilder.Entity<UserSeller>()
        .HasMany(u => u.Products)
        .WithOne(p => p.Seller)
        .HasForeignKey(p => p.SellerId);

      modelBuilder.Entity<User>()
        .HasOne(u => u.Customer)
        .WithOne(c => c.User)
        .HasForeignKey<UserCustomer>(c => c.UserId);

      modelBuilder.Entity<User>()
        .HasOne(u => u.Seller)
        .WithOne(s => s.User)
        .HasForeignKey<UserSeller>(s => s.UserId);

      modelBuilder.Entity<Delivery>()
        .HasOne(d => d.Sale)
        .WithOne(s => s.Delivery)
        .HasForeignKey<Delivery>(d => d.SaleId)
        .IsRequired();

      modelBuilder.Entity<User>()
        .HasIndex(u => u.Email)
        .IsUnique();

    }
  }
}
