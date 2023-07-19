namespace Ecomerce.Models
{
    public class User
{
    public Guid Id { get; set; }
    public string Username { get; set; }

    public string Email { get; set; }

    public string Password { get; set; }
    public string Category { get; set; }
    public UserCustomer? Customer { get; set; }
    public UserSeller? Seller { get; set; }
}

}