using Ecomerce.Data;
using Ecomerce.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;


namespace Ecomerce.Services
{
  public class SellerService : UserSellerServiceInterface
  {
    private readonly AppDbContext _context;

    public SellerService(AppDbContext context)
    {
      _context = context;
    }

    public Product PostProduct(Guid id, Product product)
    {
      try
      {
        var seller = _context.UserSellers.Find(id);
        if (seller == null)
        {
          return null;
        }
        Console.WriteLine(seller.UserId);
        Console.WriteLine(product.Name);
       if (seller.Products == null)
        {
          seller.Products = new List<Product>();
        }
        
        seller.Products.Add(product);

        _context.UserSellers.Update(seller);
        _context.SaveChanges();
        return product;
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
        throw new Exception("Não foi possível encontrar os produtos");
      }
    }

    public List<Product> GetAllProducts(Guid id)
    {
      try
      {
        var seller = _context.UserSellers
            .Include(s => s.Products)
            .FirstOrDefault(s => s.Id == id);

        if (seller != null && seller.Products != null)
        {
          return seller.Products.ToList();
        }
        else
        {
          return new List<Product>();
        }
      }
      catch (Exception)
      {
        throw new Exception("Não foi possível encontrar os produtos");
      }
    }

  }
}