namespace Ecomerce.Models
{
  public class Delivery
  {
    public Guid Id { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }
    public DateTime DeliveryDate { get; set; }
    public DateTime PreviewDate { get; set; }
    public string DeliveryStatus { get; set; }

    // Foreign Keys
    public Guid SaleId { get; set; }
    public SaleProduct Sale { get; set; }
  }

}