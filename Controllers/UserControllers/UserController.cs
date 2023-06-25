using Microsoft.AspNetCore.Mvc;
using Ecomerce.Repositories;
using Ecomerce.Models;
using Microsoft.AspNetCore.Authorization;


namespace Ecomerce.Controllers
{
  [Route("user")]
  [ApiController]
  public class UserController : ControllerBase
  {
    private readonly IUserRepository _userRepository;
    public UserController(IUserRepository userRepository)
    {
      _userRepository = userRepository;
    }

    [Authorize]
    [HttpGet]
    public IActionResult GetAll()
    {
      var users = _userRepository.GetAll();
      return Ok(users);
    }
    
    [Authorize]
    [HttpGet("{id}")]
    public IActionResult GetById(Guid id)
    {
      var user = _userRepository.GetUserById(id);
      if (user == null)
      {
        return NotFound();
      }
      return Ok(user);
    }


    [HttpPost]
    public IActionResult Post(UserModel user)
    {
      _userRepository.SaveUser(user);
      return CreatedAtAction(nameof(GetById), new { id = user.Id }, user);
    }

    [Authorize]
    [HttpPut("{id}")]
    public IActionResult Put(Guid id, UserUpdateDTO user)
    {
        var userFind = _userRepository.GetUserById(id);
        if (userFind == null)
        {
            return NotFound();
        }
        
        if (_userRepository.UpdateUser(id, user))
        {
            return Ok("User updated");
        }

        return NoContent();
    }

    [Authorize]
    [HttpDelete("{id}")]
    public IActionResult Delete(Guid id)
    {
      var user = _userRepository.GetUserById(id);
      if (user == null)
      {
        return NotFound();
      }
     if( _userRepository.DeleteUser(id))
     {
        return Ok("User deleted");
     }

      return NoContent();
    }


    [HttpPost("login")]
    public IActionResult Login(UserAuthDTO user)
    {
      var token = _userRepository.AuthtenTicateUser(user.Email, user.Password, user.Category);
      if (token == null)
      {
        return Unauthorized();
      }
      return Ok(token);
    }
  }
}