using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;
using Ecomerce.Models;
public class Product
{
  public int Id { get; set; }
  public string Name { get; set; }
  public string ImgUrl { get; set; }
  public string Description { get; set; }
  public string Category { get; set; }
  public decimal Price { get; set; }
  public int Quantity { get; set; }

  private string _characteristicsJson;

  [NotMapped]
  public Dictionary<string, string> Characteristics
  {
    get => JsonSerializer.Deserialize<Dictionary<string, string>>(_characteristicsJson);
    set => _characteristicsJson = JsonSerializer.Serialize(value);
  }

  // Foreign Keys
  public Guid? SellerId { get; set; }
  public UserSeller? Seller { get; set; }
  public Guid? ShoppingCarId { get; set; }
  public ShoppingCar? ShoppingCar { get; set; }
}
