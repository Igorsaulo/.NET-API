using Ecomerce.Models;
using Ecomerce.Data;
using System;
using System.Collections.Generic;

namespace Ecomerce.Repositories
{
    public class ProductsRepository : IProductRepository
    {
        private readonly AppDbContext _context;

        public ProductsRepository(AppDbContext context)
        {
            _context = context;
        }

        public bool SaveProduct(ProductModel product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return true;
        }

        public ProductModel GetProductById(Guid id)
        {
            return _context.Products.Find(id);
        }

        public bool UpdateProduct(ProductModel product)
        {
            var existingProduct = _context.Products.Find(product.Id);
            if (existingProduct != null)
            {
                _context.Attach(existingProduct);
                _context.Entry(existingProduct).CurrentValues.SetValues(product);
                _context.SaveChanges();
                return true;
            }
            return false;
}


        public List<ProductModel> GetAll()
        {
            return _context.Products.ToList();
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
    }
}
