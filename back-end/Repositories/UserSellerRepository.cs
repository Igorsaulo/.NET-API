using Ecomerce.Models.UserProperties;
using Ecomerce.Repositories.Interfaces;
using Ecomerce.Data;
using Microsoft.EntityFrameworkCore;

namespace Ecomerce.Repositories
{
  public class UserSellerRepository : IUserSellerInterface
  {
    private readonly AppDbContext _context;

    public UserSellerRepository(AppDbContext context)
    {
      _context = context;
    }

    public UserSeller UpdateUserSeller(UserSeller userSeller)
    {
      _context.UserSellers.Update(userSeller);
      _context.SaveChanges();
      return userSeller;
    }

    public UserSeller GetUserSellerById(Guid Id)
    {
      var userSellerFound = _context.UserSellers.Find(Id);
      return userSellerFound;
    }

    public List<UserSeller> GetAllUserSellers()
    {
      return _context.UserSellers
          .Include(u => u.Operations)
          .Include(u => u.Products)
          .ToList();
    }
  }
}