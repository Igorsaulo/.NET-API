using Ecomerce.Models.UserProperties;
using Ecomerce.Data;
using Ecomerce.Repositories.Interfaces;

namespace Ecomerce.Repositories
{
  public class UserCustomerRepository : IUserCustomerInterface
  {
    private readonly AppDbContext _context;

    public UserCustomerRepository(AppDbContext context)
    {
      _context = context;
    }

    public UserCustomer UpdateUserCustomer(Guid Id, UserCustomer userCustomer)
    {
      var userCustomerFind = _context.UserCustomers.Find(Id);
      if (userCustomerFind == null)
      {
        return null;
      }
      userCustomerFind = userCustomer;
      _context.SaveChanges();

      return userCustomer;
    }

    public UserCustomer GetUserCustomerById(Guid Id)
    {
      return _context.UserCustomers.Find(Id);
    }

    public List<UserCustomer> GetAllUserCustomers()
    {
      return _context.UserCustomers.ToList();
    }
  }
}