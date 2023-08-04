using System;
using System.Collections.Generic;
using Xunit;
using Moq;
using Ecomerce.Controllers;
using Ecomerce.Repositories.Interfaces;
using Ecomerce.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ecomerce.Tests.Controller
{
  public class UserControllerTests
  {
    [Fact]
    public void GetAll_ReturnsOkResult_WithAListOfUsers()
    {
      // Arrange
      var mockUserRepository = new Mock<IUserRepository>();
      mockUserRepository.Setup(repo => repo.GetAllUsers()).Returns(new List<User>()); // Return an empty list
      var userController = new UserController(mockUserRepository.Object);

      // Act
      var result = userController.GetAll();

      // Assert
      var okResult = Assert.IsType<OkObjectResult>(result);
      var model = Assert.IsAssignableFrom<IEnumerable<User>>(okResult.Value);
      Assert.NotNull(model);
    }


    [Fact]
    public void GetById_ReturnsOkResult_WithUser()
    {
      // Arrange
      var userId = Guid.NewGuid();
      var user = new User { Id = userId, Username = "user1" };
      var mockUserRepository = new Mock<IUserRepository>();
      mockUserRepository.Setup(repo => repo.GetUserById(userId)).Returns(user);
      var userController = new UserController(mockUserRepository.Object);

      // Act
      var result = userController.GetById(userId);

      // Assert
      var okResult = Assert.IsType<OkObjectResult>(result);
      var model = Assert.IsType<User>(okResult.Value);
      Assert.Equal(user.Id, model.Id);
      Assert.Equal(user.Username, model.Username);
    }

    [Fact]
    public void Post_ReturnsCreatedAtActionResult_WithNewUser()
    {
      // Arrange
      var newUser = new User { Username = "newuser", Email = "newuser@example.com" };
      var mockUserRepository = new Mock<IUserRepository>();
      var userController = new UserController(mockUserRepository.Object);

      // Act
      var result = userController.Post(newUser);

      // Assert
      var createdAtActionResult = Assert.IsType<CreatedAtActionResult>(result);
      var model = Assert.IsType<User>(createdAtActionResult.Value);
      Assert.Equal(newUser.Username, model.Username);
      Assert.Equal(newUser.Email, model.Email);
    }

    [Fact]
    public void Put_ExistingUser_ReturnsOkResult_UserUpdated()
    {
      // Arrange
      var userId = Guid.NewGuid();
      var existingUser = new User { Id = userId, Username = "existinguser" };
      var updatedUser = new User { Id = userId, Username = "updateduser" };
      var mockUserRepository = new Mock<IUserRepository>();
      mockUserRepository.Setup(repo => repo.GetUserById(userId)).Returns(existingUser);
      mockUserRepository.Setup(repo => repo.UpdateUser(userId, updatedUser)).Returns(true);
      var userController = new UserController(mockUserRepository.Object);

      // Act
      var result = userController.Put(userId, updatedUser);

      // Assert
      var okResult = Assert.IsType<OkObjectResult>(result);
      Assert.Equal("User updated", okResult.Value);
    }

    [Fact]
    public void Delete_ExistingUser_ReturnsOkResult_UserDeleted()
    {
      // Arrange
      var userId = Guid.NewGuid();
      var existingUser = new User { Id = userId, Username = "existinguser" };
      var mockUserRepository = new Mock<IUserRepository>();
      mockUserRepository.Setup(repo => repo.GetUserById(userId)).Returns(existingUser);
      mockUserRepository.Setup(repo => repo.DeleteUser(userId)).Returns(true);
      var userController = new UserController(mockUserRepository.Object);

      // Act
      var result = userController.Delete(userId);

      // Assert
      var okResult = Assert.IsType<OkObjectResult>(result);
      Assert.Equal("User deleted", okResult.Value);
    }
  }
}
