using Ecomerce.Models;

public class SaleProduct
{
  public Guid Id { get; set; }
  public int UserSellerId { get; set; }
  public List<ProductModel> Products { get; set; }
  public List<DeliveryProperties> Deliveries { get; set; }
}