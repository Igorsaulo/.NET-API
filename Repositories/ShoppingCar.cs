using Ecomerce.Models;
using Ecomerce.Data;


namespace Ecomerce.Repositories
{
  public class ShoppingCarRepository
  {
    private readonly AppDbContext _context;

    public ShoppingCarRepository(AppDbContext context)
    {
      _context = context;
    }

    public bool SaveShoppingCar(ShoppingCar shoppingCar)
    {
      _context.ShoppingCar.Add(shoppingCar);
      _context.SaveChanges();
      return true;
    }

    public ShoppingCar GetShoppingCarById(int id)
    {
      return _context.ShoppingCar.Find(id);
    }

    public bool UpdateShoppingCar(ShoppingCar shoppingCar)
    {
      _context.ShoppingCar.Update(shoppingCar);
      _context.SaveChanges();
      return true;
    }

    public bool DeleteShoppingCar(int id)
    {
      var shoppingCar = this.GetShoppingCarById(id);
      _context.ShoppingCar.Remove(shoppingCar);
      _context.SaveChanges();
      return true;
    }

  }
}