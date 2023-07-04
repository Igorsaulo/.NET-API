namespace Ecomerce.Repositories
{
  public class UserUpdateDTO{
    public string Username { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string Category { get; set; }
    public bool IsAdmin { get; set; }
  }
}