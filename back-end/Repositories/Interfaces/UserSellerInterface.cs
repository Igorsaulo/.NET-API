using Ecomerce.Models.UserProperties;

namespace Ecomerce.Repositories.Interfaces
{
  public interface IUserSellerInterface
  {
    UserSeller UpdateUserSeller(UserSeller userSeller);
    UserSeller GetUserSellerById(Guid id);
    List<UserSeller> GetAllUserSellers();
  }
}