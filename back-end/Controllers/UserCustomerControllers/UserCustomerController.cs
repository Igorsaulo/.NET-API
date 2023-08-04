using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Ecomerce.Repositories.Interfaces;
using Ecomerce.Services.Interfaces;
using Ecomerce.Models.UserProperties;
using System;
using Microsoft.AspNetCore.Http;
using System;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace Ecomerce.Controllers
{
  [Route("user/customer")]
  public class UserCustomerController : ControllerBase
  {
    private readonly IUserCustomerInterface _userCustomerRepository;
    private readonly CarshoppingServiceInterface _shoppingService;

    public UserCustomerController(IUserCustomerInterface userCustomerRepository, CarshoppingServiceInterface shoppingService)
    {
      _userCustomerRepository = userCustomerRepository;
      _shoppingService = shoppingService;
    }
    [HttpGet("{id}")]
    public IActionResult GetById(Guid id)
    {
      var userCustomer = _userCustomerRepository.GetUserCustomerById(id);
      if (userCustomer == null)
      {
        return NotFound();
      }
      return Ok(userCustomer);
    }

    [HttpPut("{id}")]
    public IActionResult Put(Guid id, UserCustomer userCustomer)
    {
      var response = _userCustomerRepository.UpdateUserCustomer(id, userCustomer);
      if (response == null)
      {
        return NotFound();
      }
      return Ok(response);
    }

    [HttpGet]
    public IActionResult GetAll()
    {
      var response = _userCustomerRepository.GetAllUserCustomers();
      return Ok(response);
    }

    [HttpGet("{id}/shoppingcar")]
    public IActionResult GetShoppingCarById(Guid id)
    {
      var response = _shoppingService.GetShoppingCarById(id);
      if (response == null)
      {
        return NotFound();
      }
      return Ok(response);
    }

    [HttpPost("{id}/shoppingcar")]
    public async Task<IActionResult> AddProduct(Guid id)
    {
      try
      {
        using (StreamReader reader = new StreamReader(Request.Body))
        {
          var body = await reader.ReadToEndAsync();
          var jsonObject = JsonConvert.DeserializeObject<JObject>(body);

          if (jsonObject.TryGetValue("productId", out var productIdToken) && jsonObject.TryGetValue("quantity", out var quantityToken))
          {
            if (Guid.TryParse(productIdToken.ToString(), out Guid productId) && int.TryParse(quantityToken.ToString(), out int quantity))
            {
              Console.WriteLine(productId);
              Console.WriteLine(quantity);

              var response = _shoppingService.AddProduct(id, productId, quantity);
              if (response == null)
              {
                return NotFound();
              }

              return Ok(response);
            }
          }

          // Caso não consiga obter productId ou quantity, retornar BadRequest
          return BadRequest("productId ou quantity inválidos");
        }
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
        return BadRequest("Erro ao processar a requisição");
      }
    }


    [HttpDelete("{id}/shoppingcar")]
    public IActionResult RemoveProduct(Guid id, Guid productId)
    {
      var response = _shoppingService.RemoveProduct(id, productId);
      if (response == false)
      {
        return BadRequest();
      }
      return Ok(response);
    }

    [HttpPut("{id}/shoppingcar/{productId}")]
    public IActionResult UpdateQuantity(Guid id, Guid productId, int quantity)
    {
      var response = _shoppingService.UpdateProductQuantify(id, productId, quantity);
      if (response == null)
      {
        return BadRequest();
      }
      return Ok(response);
    }
  }
}