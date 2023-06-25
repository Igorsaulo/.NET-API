using Microsoft.EntityFrameworkCore;
using Ecomerce.Models;

namespace Ecomerce.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<ProductModel> Products { get; set; }
        public DbSet<ShoppingCar> ShoppingCar { get; set; }
        public DbSet<UserModel> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("DataSource=app.db;Cache=Shared");
        }
              protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserModel>()
                .HasIndex(u => u.Email)
                .IsUnique();
            base.OnModelCreating(modelBuilder);
        }
    }
}
