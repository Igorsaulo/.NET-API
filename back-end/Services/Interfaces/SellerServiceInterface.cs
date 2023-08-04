using Ecomerce.Models.UserProperties;
using Ecomerce.Models;

namespace Ecomerce.Services.Interfaces
{
  public interface UserSellerServiceInterface
  {
    Product PostProduct(Guid id,Product product);
    
    List<Product> GetAllProducts(Guid id);
  }
}