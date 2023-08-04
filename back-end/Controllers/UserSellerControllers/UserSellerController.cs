using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Ecomerce.Repositories.Interfaces;
using Ecomerce.Services.Interfaces;
using Ecomerce.Models.UserProperties;
using Microsoft.AspNetCore.Http;
using System;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Ecomerce.Controllers
{
  [Route("user/seller")]
  public class UserSellerController : Controller
  {
    private readonly IUserSellerInterface _userSellerRepository;
    private readonly UserSellerServiceInterface _userSellerService;

    public UserSellerController(IUserSellerInterface userSellerRepository, UserSellerServiceInterface userSellerService)
    {
      _userSellerRepository = userSellerRepository;
      _userSellerService = userSellerService;
    }

    [HttpGet("{id}")]
    public IActionResult GetById(Guid id)
    {
      var userSeller = _userSellerRepository.GetUserSellerById(id);
      if (userSeller == null)
      {
        return NotFound();
      }
      return Ok(userSeller);
    }

    [HttpPut("{id}")]
    public IActionResult Put(Guid Id, UserSeller userSeller)
    {
      var response = _userSellerRepository.UpdateUserSeller(userSeller);
      if (response == null)
      {
        return NotFound();
      }
      return Ok(response);

    }

    [HttpGet]
    public IActionResult GetAll()
    {
      var response = _userSellerRepository.GetAllUserSellers();
      if (response == null)
      {
        return NotFound();
      }
      return Ok(response);
    }

    // [HttpPost("{id}/product")]
    // public async Task<IActionResult> AnunciarProduto(Guid id, Product product)
    // {
    //   var response = _userSellerService.PostProduct(id, product);
    //   if (response == null)
    //   {
    //     return NotFound();
    //   }
    //   return Ok(response);
    // }
    [HttpPost("{id}/product")]
    public async Task<IActionResult> AnunciarProduto(Guid id)
    {
      try
      {
        using (StreamReader reader = new StreamReader(Request.Body))
        {
          var body = await reader.ReadToEndAsync();

          Product product = JsonConvert.DeserializeObject<Product>(body);

          var response = _userSellerService.PostProduct(id, product);
          if (response == null)
          {
            return NotFound();
          }
          return Ok(response);
        }
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
        return BadRequest("Erro ao processar a requisição");
      }
    }

    [HttpGet("{id}/products")]
    public IActionResult GetAllProducts(Guid id)
    {
      var response = _userSellerService.GetAllProducts(id);
      if (response == null)
      {
        return NotFound();
      }
      return Ok(response);
    }
  }
}