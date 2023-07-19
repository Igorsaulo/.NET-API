namespace Ecomerce.Models
{
  public class ShoppingCar
  {
    public Guid Id { get; set; }
    public double Total { get; set; } = 0.0;
    public int Quantify { get; set; } = 0;
    public ICollection<Product>? Products { get; set; }

    // Foreign Keys
    public Guid UserId { get; set; }
    public User User { get; set; }
  }
}