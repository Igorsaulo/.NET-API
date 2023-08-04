using Ecomerce.Data;
using Ecomerce.Models;
using Ecomerce.Utils;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;
using System.Text.Json.Serialization;
using Ecomerce.Models.UserProperties;
using Ecomerce.Models.UserProperties.UserCustomerProperties;
using Ecomerce.Repositories.Interfaces;

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

      var options = new JsonSerializerOptions
      {
        ReferenceHandler = ReferenceHandler.Preserve
      };

      if (user.Category == "customer")
      {
        user.UserCustomer = new UserCustomer();
        user.UserCustomer.ShoppingCar = new ShoppingCar();
      }
      else
      {
        user.UserSeller = new UserSeller();
      }

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

    public string AuthtenTicateUser(string email, string password, string category)
    {
      try
      {
        return _authService.Authenticate(email, password, category);
      }
      catch (Exception e)
      {
        Console.WriteLine(e);
        return "Dados inválidos";
      }
    }

    public List<User> GetAllUsers()
    {
      return _context.Users
          .Include(u => u.UserCustomer)
          .Include(u => u.UserSeller)
          .ToList();
    }
  }
}
