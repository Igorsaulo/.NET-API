using Ecomerce.Data;
using Ecomerce.Models;
using Ecomerce.Services;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Ecomerce.Repositories
{
  public class UserRepository : IUserRepository
  {
    private readonly AppDbContext _context;

    private readonly AuthInterface _authService;

    public UserRepository(AppDbContext context)
    {
      _context = context;
      _authService = new AuthService(_context);
    }

    public bool SaveUser(User user)
    {
      user.Password = PassWordManager.HashPassword(user.Password);
      if (user.Category == "Customer")
      {
        UserCustomer customer = new UserCustomer();
        customer.UserId = user.Id;
        user.Customer = customer;
        _context.UserCustomers.Add(customer);
      }
      else
      {
        UserSeller seller = new UserSeller();
        seller.UserId = user.Id;
        user.Seller = seller;
        _context.UserSellers.Add(seller);
      }

      var options = new JsonSerializerOptions
      {
        ReferenceHandler = ReferenceHandler.Preserve
      };

      var json = JsonSerializer.Serialize(user, options);

      _context.Users.Add(user);
      _context.SaveChanges();

      return true;
    }
    public User GetUserById(Guid id)
    {
      var user = _context.Users.Find(id);
      return user;
    }
    public bool UpdateUser(Guid id, User user)
    {
      if (user.Password != null)
      {
        user.Password = PassWordManager.HashPassword(user.Password);
      }

      var existingUser = _context.Users.Find(id);
      if (existingUser != null)
      {
        _context.Entry(existingUser).State = EntityState.Detached;
      }
      if (user.Customer != null)
      {
        UserCustomer customer = new UserCustomer();

      }

      _context.Users.Update(user);
      _context.SaveChanges();

      return true;
    }

    public bool DeleteUser(Guid id)
    {
      var user = this.GetUserById(id);
      _context.Users.Remove(user);
      _context.SaveChanges();
      return true;
    }

    public List<User> GetAll()
    {
      var users = _context.Users
          .Include(u => u.Customer)
          .Include(u => u.Seller)
          .ToList();

      return users;

    }

    public string AuthtenTicateUser(string email, string password, string category)
    {
      return _authService.Authenticate(email, password, category);
    }


  }
}
