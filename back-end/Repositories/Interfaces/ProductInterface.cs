using Ecomerce.Models;


namespace Ecomerce.Repositories
{
    public interface IProductRepository
    {
        bool SaveProduct(Product product);
        Product GetProductById(Guid id);
        bool UpdateProduct(Product product);
        bool DeleteProduct(Guid id);
        List<Product> GetAll();
    }
}