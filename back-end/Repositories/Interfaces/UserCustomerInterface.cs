using Ecomerce.Models.UserProperties;

namespace Ecomerce.Repositories.Interfaces
{
  public interface IUserCustomerInterface
  {
    UserCustomer UpdateUserCustomer(Guid Id, UserCustomer userCustomer);
    UserCustomer GetUserCustomerById(Guid Id);
    List<UserCustomer> GetAllUserCustomers();
  }
}