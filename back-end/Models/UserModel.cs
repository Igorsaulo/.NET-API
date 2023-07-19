namespace Ecomerce.Models
{
  public class User
  {
    public Guid Id { get; set; }
    public string Username { get; set; }

    public string Email { get; set; }

    public string Password { get; set; }
    public string Category { get; set; }
    public ShoppingCar ShoppingCar { get; set; }
    public ICollection<Shopping>? Shopping { get; set; }
  }

}