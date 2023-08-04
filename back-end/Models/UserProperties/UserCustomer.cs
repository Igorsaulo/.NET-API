using Ecomerce.Models.UserProperties.UserCustomerProperties;

namespace Ecomerce.Models.UserProperties
{
  public class UserCustomer
  {
    public Guid Id { get; set; }

    public ShoppingCar ShoppingCar { get; set; }
    public ICollection<Operation>? Shopping { get; set; }

    // Foreign Keys
    public Guid UserId { get; set; }
    public User User { get; set; }
  }
}