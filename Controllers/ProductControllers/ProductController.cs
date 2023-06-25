using Microsoft.AspNetCore.Mvc;
using Ecomerce.Repositories;
using Ecomerce.Models;
using Microsoft.AspNetCore.Authorization;


namespace Ecomerce.Controllers
{
  [Route("product")]
  [ApiController]
  public class ProductController : ControllerBase
  {
      private readonly IProductRepository _productRepository;
      public ProductController(IProductRepository productRepository)
      {
          _productRepository = productRepository;
      }


      [Authorize]
      [HttpGet]
      public IActionResult GetAll()
      {
          var products = _productRepository.GetAll();
          return Ok(products);
      }


      [Authorize]
      [HttpGet("{id}")]
      public IActionResult GetById(Guid id)
      {
          var product = _productRepository.GetProductById(id);
          if (product == null)
          {
              return NotFound();
          }
          return Ok(product);
      }    

      [Authorize]
      [HttpPost]
      public IActionResult Post(ProductModel product)
      {
          _productRepository.SaveProduct(product);
          return CreatedAtAction(nameof(GetById), new { id = product.Id }, product);
      }


      [Authorize]
      [HttpPut]
      public IActionResult Put(ProductModel product)
      {
          var productUpdate = _productRepository.UpdateProduct(product);
          if (productUpdate != null)
          {
              return Ok("Product updated");
          }
          else if(productUpdate == null)
          {
              return NotFound();
          }
          return BadRequest();
      }


    [Authorize]
    [HttpDelete("{id}")]
    public IActionResult Delete(Guid id)
    {
        var product = _productRepository.DeleteProduct(id);
        if (product != null)
        {
            return Ok("Product deleted");
        }
        else if(product == null)
        {
            return NotFound();
        }
        return BadRequest();
    }

  }
}