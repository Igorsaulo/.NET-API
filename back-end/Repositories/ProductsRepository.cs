using Ecomerce.Data;


namespace Ecomerce.Repositories
{
  public class ProductsRepository : IProductRepository
  {
    private readonly AppDbContext _context;

    public ProductsRepository(AppDbContext context)
    {
      _context = context;
    }

    public bool SaveProduct(Product product)
    {
      _context.Products.Add(product);
      _context.SaveChanges();
      return true;
    }

    public List<Product> GetAll()
    {
      try{
        return _context.Products.ToList();
      }
      catch(Exception ex){
        Console.WriteLine(ex.Message);
        throw new Exception("Não foi possível encontrar os produtos");
      }
    }


    public bool DeleteProduct(Guid id)
    {
      var product = this.GetProductById(id);
      if (product != null)
      {
        _context.Products.Remove(product);
        _context.SaveChanges();
        return true;
      }
      return false;
    }
    public Product GetProductById(Guid id)
    {
      return _context.Products.Find(id);
    }
    public bool UpdateProduct(Product product)
    {
      _context.Products.Update(product);
      _context.SaveChanges();
      return true;
    }

  }
}
