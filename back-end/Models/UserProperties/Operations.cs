

namespace Ecomerce.Models.UserProperties
{
  public class Operation
  {
    public Guid Id { get; set; }
    public Product Product { get; set; }
    public Delivery Delivery { get; set; }
    public int Quantity { get; set; }
    public decimal TotalPrice { get; set; }
    public DateTime ShoppingDate { get; set; }

    // Foreign Keys
    public Guid UserSellerId { get; set; }

    public UserSeller UserSeller { get; set; }
    public Guid UserCustomerId { get; set; }
    public UserCustomer UserCustomer { get; set; }
  }
}