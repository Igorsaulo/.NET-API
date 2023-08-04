using Ecomerce.Models.UserProperties.UserCustomerProperties;
using Ecomerce.Models;

namespace Ecomerce.Services.Interfaces
{
  public interface CarshoppingServiceInterface
  {
    Product AddProduct(Guid id,Guid productId,int quantity);
    bool RemoveProduct(Guid id,Guid productId);
    Product UpdateProductQuantify(Guid id,Guid productId,int quantify);
    ShoppingCar GetShoppingCarById(Guid id); 
  }
}