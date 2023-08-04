using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;
using Ecomerce.Models.UserProperties.UserCustomerProperties;
using Ecomerce.Models.UserProperties;

public class Product
{
  public Guid Id { get; set; }
  public string Name { get; set; }
  public List<string> Images { get; set; }
  public string Description { get; set; }
  public string Category { get; set; }
  public decimal Price { get; set; }
  public int Quantity { get; set; }
  [NotMapped]
  public Dictionary<string, string> Characteristics {get; set;}
  [Column("Characteristics")]
  public string CharacteristicsSerialized
  {
    get => JsonSerializer.Serialize(Characteristics);
    set => Characteristics = JsonSerializer.Deserialize<Dictionary<string, string>>(value);
  }

  // Foreign Keys
  public Guid? ShoppingCarId { get; set; }
  public ShoppingCar? ShoppingCar { get; set; }
  public Guid? OperationId { get; set; }
  public Operation? Operation { get; set; }
  public Guid? UserSellerId { get; set; }
  public UserSeller? UserSeller { get; set; }
}
