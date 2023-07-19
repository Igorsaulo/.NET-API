namespace Ecomerce.Models
{
  public class UserSeller
  {
    public Guid Id { get; set; }
    public ICollection<Product>? Products { get; set; }
    public int TotalSales { get; set; } = 0;
    public int Rating { get; set; } = 0;
    public float Revenue { get; set; } = 0.0f;
    public int TotalProducts { get; set; } = 0;
    public ICollection<SaleProduct>? Sales { get; set; }

    // Foreign Keys

    public Guid UserId { get; set; }
    public User User { get; set; }

  }
}