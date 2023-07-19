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
      user.ShoppingCar = new ShoppingCar();
      user.ShoppingCar.UserId = user.Id;

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
          .Include(c => c.ShoppingCar)
          .ThenInclude(sc => sc.Products)
          .ToList();

      return users;

    }
    public bool addProducInShoppingCar(Guid id, Product product)
    {
      try
      {
        var customer = _context.Users
            .Include(u => u.ShoppingCar)
            .ThenInclude(sc => sc.Products)
            .FirstOrDefault(u => u.Id == id);

        if (customer == null)
        {
          return false;
        }

        if (customer.ShoppingCar == null)
        {
          customer.ShoppingCar = new ShoppingCar
          {
            UserId = customer.Id
          };
          _context.SaveChanges();
        }
        customer.ShoppingCar.Products.Add(product);

        _context.SaveChanges();
        return true;
      }
      catch (Exception e)
      {
        Console.WriteLine(e);
        return false;
      }
    }


    public bool removeProductInShoppingCar(Guid id, Product product)
    {
      try
      {
        var user = _context.Users
            .Include(c => c.ShoppingCar)
            .ThenInclude(sc => sc.Products)
            .FirstOrDefault(u => u.Id == id);

        if (user == null || user.ShoppingCar == null)
        {
          return false;
        }
        var shoppingCar = user.ShoppingCar;
        var productToRemove = shoppingCar.Products.FirstOrDefault(p => p.Id == product.Id);

        if (productToRemove != null)
        {
          shoppingCar.Products.Remove(productToRemove);
          _context.SaveChanges();
          return true;
        }
        else
        {
          return false;
        }
      }
      catch (Exception e)
      {
        Console.WriteLine(e);
        return false;
      }
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
  }
}
