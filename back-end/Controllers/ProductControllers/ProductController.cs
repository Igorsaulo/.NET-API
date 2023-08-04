using Microsoft.AspNetCore.Mvc;
using Ecomerce.Repositories;
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


      [HttpGet]
      public IActionResult GetAll()
      {
          var products = _productRepository.GetAll();
          return Ok(products);
      }


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
      public IActionResult Post(Product product)
      {
        _productRepository.SaveProduct(product);
        return Ok(product);
      }


      [Authorize]
      [HttpPut]
      public IActionResult Put(Product product)
      {
          var productUpdate = _productRepository.UpdateProduct(product);
          if (productUpdate != null)
          {
              return Ok(product);
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
            return Ok(true);
        }
        else if(product == null)
        {
            return NotFound();
        }
        return BadRequest();
    }

  }
}