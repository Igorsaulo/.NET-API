using Ecomerce.Models;


namespace Ecomerce.Repositories
{
    public interface IProductRepository
    {
        bool SaveProduct(ProductModel product);
        ProductModel GetProductById(Guid id);
        bool UpdateProduct(ProductModel product);
        bool DeleteProduct(Guid id);
        List<ProductModel> GetAll();
    }
}