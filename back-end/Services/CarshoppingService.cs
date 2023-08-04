using Ecomerce.Data;
using Ecomerce.Services.Interfaces;
using Ecomerce.Models.UserProperties.UserCustomerProperties;
using Microsoft.EntityFrameworkCore;

namespace Ecomerce.Services
{
  public class CarshoppingService : CarshoppingServiceInterface
  {
    private readonly AppDbContext _context;

    public CarshoppingService(AppDbContext context)
    {
      _context = context;
    }
    public Product AddProduct(Guid id, Guid productId, int quantity)
    {
      try
      {
        var userCustomer = _context.UserCustomers
            .Include(s => s.ShoppingCar)
            .ThenInclude(s => s.Products)
            .FirstOrDefault(s => s.Id == id);
        var product = _context.Products.Find(productId);
        if (userCustomer.ShoppingCar == null)
        {
          userCustomer.ShoppingCar = new ShoppingCar();
          userCustomer.ShoppingCar.Products = new List<Product>();
        }
        if (userCustomer.ShoppingCar.Products == null)
        {
          userCustomer.ShoppingCar.Products = new List<Product>();
        }

        // Verificar se o produto já existe no carrinho
        var existingProduct = userCustomer.ShoppingCar.Products.FirstOrDefault(p => p.Id == productId);
        if (existingProduct != null)
        {
          // Se o produto já existe, apenas atualize a quantidade
          existingProduct.Quantity += quantity;
        }
        else
        {
          // Se o produto ainda não existe, adicione-o ao carrinho com a quantidade informada
          product.Quantity = quantity;
          userCustomer.ShoppingCar.Products.Add(product);
        }

        _context.UserCustomers.Update(userCustomer);
        _context.SaveChanges();
        return product;
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
        throw new Exception("Não foi possível adicionar o produto");
      }
    }
  

    public bool RemoveProduct(Guid id, Guid productId)
    {
      try
      {
        var userCustomer = _context.UserCustomers.Find(id);
        var product = _context.Products.Find(productId);
        userCustomer.ShoppingCar.Products.Remove(product);
        _context.SaveChanges();
        return true;
      }
      catch (Exception)
      {
        throw new Exception("Não foi possível remover o produto");
      }
    }

    public Product UpdateProductQuantify(Guid id, Guid productId, int quantify)
    {
      try
      {
        var userCustomer = _context.UserCustomers.Find(id);
        var product = _context.Products.Find(productId);
        userCustomer.ShoppingCar.Products.Remove(product);
        product.Quantity = quantify;
        userCustomer.ShoppingCar.Products.Add(product);
        _context.SaveChanges();
        return product;
      }
      catch (Exception)
      {
        throw new Exception("Não foi possível atualizar a quantidade do produto");
      }
    }

    public ShoppingCar GetShoppingCarById(Guid id)
    {
      try
      {
        return _context.ShoppingCars.Find(id);
      }
      catch (Exception)
      {
        throw new Exception("Não foi possível encontrar o carrinho");
      }
    }
  }
}
