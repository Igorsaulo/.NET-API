namespace Ecomerce.Models
{
  public class UserCustomer
  {

    public Guid Id { get; set; }
    public ShoppingCar? ShoppingCar { get; set; }
    public ICollection<SaleProduct>? Shopping { get; set; }

    // Foreign Keys
    public Guid UserId { get; set; }
    public User User { get; set; }
  }

}