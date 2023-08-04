namespace Ecomerce.Models.UserProperties
{
  public class UserSeller
  {
    public Guid Id { get; set; }
    public ICollection<Product>? Products { get; set; }
    public ICollection<Operation>? Operations { get; set; }

    // Foreign Keys
    public Guid UserId { get; set; }
    public User User { get; set; }
  }
}