using System;
using System.Collections.Generic;
using Xunit;
using Moq;
using Ecomerce.Controllers;
using Ecomerce.Repositories.Interfaces;
using Ecomerce.Models.UserProperties;
using Microsoft.AspNetCore.Mvc;
using Ecomerce.Services.Interfaces;
using Ecomerce.Models;

namespace Ecomerce.Tests.Controller
{
  public class SellerControllerTests
  {
    [Fact]
    public void GetAll_ReturnsOkResult_WithAListOfUserSellers()
    {
      // Arrange
      var mockUserSellerRepository = new Mock<IUserSellerInterface>();
      mockUserSellerRepository.Setup(repo => repo.GetAllUserSellers()).Returns(new List<UserSeller>()); // Return an empty list
      var mockUserSellerService = new Mock<UserSellerServiceInterface>();
      var userSellerController = new UserSellerController(mockUserSellerRepository.Object, mockUserSellerService.Object);

      // Act
      var result = userSellerController.GetAll();

      // Assert
      var okResult = Assert.IsType<OkObjectResult>(result);
      var model = Assert.IsAssignableFrom<IEnumerable<UserSeller>>(okResult.Value);
      Assert.NotNull(model);
    }

    [Fact]
    public void GetById_ReturnsOkResult_WithUserSeller()
    {
      // Arrange
      var userSellerId = Guid.NewGuid();
      var userSeller = new UserSeller { Id = userSellerId };
      var mockUserSellerRepository = new Mock<IUserSellerInterface>();
      mockUserSellerRepository.Setup(repo => repo.GetUserSellerById(userSellerId)).Returns(userSeller);
      var mockUserSellerService = new Mock<UserSellerServiceInterface>();
      var userSellerController = new UserSellerController(mockUserSellerRepository.Object, mockUserSellerService.Object);

      // Act
      var result = userSellerController.GetById(userSellerId);

      // Assert
      var okResult = Assert.IsType<OkObjectResult>(result);
      var model = Assert.IsType<UserSeller>(okResult.Value);
      Assert.Equal(userSeller, model);
      Assert.Equal(userSeller, model);
    }

    [Fact]
    public void PostProduct_ReturnsCreatedAtActionResult_WithNewUserSeller()
    {
      // Arrange
      var userSellerId = Guid.NewGuid();
      var userSeller = new UserSeller { Id = userSellerId };
      var product =
      new Product
      {
        Id = new Guid(),
        Name = "Product 1",
        Price = 10.10M,
        Quantity = 10,
        Description = "Description 1",
        Category = "Category 1",
        Images = new List<string>(){"Image 1"},
        Characteristics =
        new Dictionary<string, string>()
          {
              {"key1","value1"},
              {"key2","value2"},
              {"key3","value3"}
          }
      };
      var mockUserSellerRepository = new Mock<IUserSellerInterface>();
      mockUserSellerRepository.Setup(repo => repo.GetUserSellerById(userSellerId)).Returns(userSeller);
      var mockUserSellerService = new Mock<UserSellerServiceInterface>();
      mockUserSellerService.Setup(repo => repo.PostProduct(userSellerId, product)).Returns(product);
      var userSellerController = new UserSellerController(mockUserSellerRepository.Object, mockUserSellerService.Object);

      // Act
      var result = userSellerController.AnunciarProduto(userSellerId);

      // Assert
      var okObjectResult = Assert.IsType<OkObjectResult>(result);
      var model = Assert.IsType<Product>(okObjectResult.Value);
      Assert.Equal(product, model);
    }

    [Fact]
    public void UpdateSeller_ReturnsOkResult_WithUpdatedUserSeller()
    {
      // Arrange
      var userSellerId = Guid.NewGuid();
      var userSeller = new UserSeller { Id = userSellerId };
      var mockUserSellerRepository = new Mock<IUserSellerInterface>();
      mockUserSellerRepository.Setup(repo => repo.UpdateUserSeller(userSeller)).Returns(userSeller);
      var mockUserSellerService = new Mock<UserSellerServiceInterface>();
      var userSellerController = new UserSellerController(mockUserSellerRepository.Object, mockUserSellerService.Object);

      // Act
      var result = userSellerController.Put(userSellerId, userSeller);

      // Assert
      var okObjectResult = Assert.IsType<OkObjectResult>(result);
      var model = Assert.IsType<UserSeller>(okObjectResult.Value);
      Assert.Equal(userSeller, model);
    }

    [Fact]
    public void GetAllProducts_ReturnsOkResult_WithAListOfProducts()
    {
      // Arrange
      var products = new List<Product>
      {
        new Product
        {
          Id = new Guid(),
          Name = "Product 1",
          Price = 10.10M,
          Quantity = 10,
          Description = "Description 1",
          Category = "Category 1",
          Images = new List<string>(){"Image 1"},
          Characteristics =
          new Dictionary<string, string>()
          {
            {"key1","value1"},
            {"key2","value2"},
            {"key3","value3"}
          }
        },
        new Product
        {
          Id = new Guid(),
          Name = "Product 2",
          Price = 20.20M,
          Quantity = 20,
          Description = "Description 2",
          Category = "Category 2",
         Images = new List<string>(){"Image 2"},
          Characteristics =
          new Dictionary<string, string>()
          {
            {"key1","value1"},
            {"key2","value2"},
            {"key3","value3"}
          }
        },
        new Product
        {
          Id = new Guid(),
          Name = "Product 3",
          Price = 30.30M,
          Quantity = 30,
          Description = "Description 3",
          Category = "Category 3",
          Images = new List<string>(){"Image 3"},
          Characteristics =
          new Dictionary<string, string>()
          {
            {"key1","value1"},
            {"key2","value2"},
            {"key3","value3"}
          }
        }
      };
      
      var userSellerId = Guid.NewGuid();
      var userSeller = new UserSeller { Id = userSellerId, Products = products };
      var mockUserSellerService = new Mock<UserSellerServiceInterface>();
      mockUserSellerService.Setup(repo => repo.GetAllProducts(userSellerId)).Returns(products);
      var mockUserSellerRepository = new Mock<IUserSellerInterface>();
      mockUserSellerRepository.Setup(repo => repo.GetUserSellerById(userSellerId)).Returns(userSeller);
      var userSellerController = new UserSellerController(mockUserSellerRepository.Object, mockUserSellerService.Object);

      // Act
      var result = userSellerController.GetAllProducts(userSellerId);

      // Assert
      var okObjectResult = Assert.IsType<OkObjectResult>(result);
      var model = Assert.IsAssignableFrom<IEnumerable<Product>>(okObjectResult.Value);
      Assert.NotNull(model);
    }
  }
}