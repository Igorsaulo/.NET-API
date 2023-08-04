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
using Ecomerce.Models.UserProperties.UserCustomerProperties;

namespace Ecomerce.Tests.Controller
{
  public class CustomerControllerTest
  {
    [Fact]
    public void GetAll_ReturnsOkResult_WithAListOfCustomers()
    {
      // Arrange
      var customers = new List<UserCustomer>()
    {
        new UserCustomer { Id = Guid.NewGuid() },
        new UserCustomer { Id = Guid.NewGuid() },
        new UserCustomer { Id = Guid.NewGuid() }
    };

      var mockCustomerRepository = new Mock<IUserCustomerInterface>();
      mockCustomerRepository.Setup(repo => repo.GetAllUserCustomers()).Returns(customers);
      var mockCustomerService = new Mock<CarshoppingServiceInterface>();
      var customerController = new UserCustomerController(mockCustomerRepository.Object, mockCustomerService.Object);

      // Act
      var result = customerController.GetAll();

      // Assert
      var okResult = Assert.IsType<OkObjectResult>(result);
      var model = Assert.IsAssignableFrom<IEnumerable<UserCustomer>>(okResult.Value);
      Assert.NotNull(model);
      Assert.Equal(customers, model);
    }

    [Fact]
    public void GetById_ReturnsOkResult_WithCustomer()
    {
      // Arrange
      var customerId = Guid.NewGuid();
      var customer = new UserCustomer { Id = customerId };
      var mockCustomerRepository = new Mock<IUserCustomerInterface>();
      mockCustomerRepository.Setup(repo => repo.GetUserCustomerById(customerId)).Returns(customer);
      var mockCustomerService = new Mock<CarshoppingServiceInterface>();
      var customerController = new UserCustomerController(mockCustomerRepository.Object, mockCustomerService.Object);

      // Act
      var result = customerController.GetById(customerId);

      // Assert
      var okResult = Assert.IsType<OkObjectResult>(result);
      var model = Assert.IsType<UserCustomer>(okResult.Value);
      Assert.Equal(customer, model);
    }

    [Fact]
    public void UpdateCustomer_ReturnsOkResult_WithUpdatedCustomer()
    {
      // Arrange
      var customerId = Guid.NewGuid();
      var customer = new UserCustomer { Id = customerId };
      var mockCustomerRepository = new Mock<IUserCustomerInterface>();
      mockCustomerRepository.Setup(repo => repo.UpdateUserCustomer(customer.Id,customer)).Returns(customer);
      var mockCustomerService = new Mock<CarshoppingServiceInterface>();
      var customerController = new UserCustomerController(mockCustomerRepository.Object, mockCustomerService.Object);

      // Act
      var result = customerController.Put(customerId, customer);

      // Assert
      var okResult = Assert.IsType<OkObjectResult>(result);
      var model = Assert.IsType<UserCustomer>(okResult.Value);
      Assert.Equal(customer, model);
    }

    [Fact]
    public void AddProductToShoppingCart_ReturnsOkResult_WithUpdatedCustomer()
    {
      // Arrange
      var customerId = Guid.NewGuid();
      var customer = new UserCustomer { Id = customerId };
      var product = new Product { Id = Guid.NewGuid() };
      var mockCustomerRepository = new Mock<IUserCustomerInterface>();
      mockCustomerRepository.Setup(repo => repo.GetUserCustomerById(customerId)).Returns(customer);
      var mockCustomerService = new Mock<CarshoppingServiceInterface>();
      mockCustomerService.Setup(repo => repo.AddProduct(customerId, product.Id,2)).Returns(product);
      var customerController = new UserCustomerController(mockCustomerRepository.Object, mockCustomerService.Object);

      // Act
      var result = customerController.AddProduct(customerId);

      // Assert
      var okResult = Assert.IsType<OkObjectResult>(result);
      var model = Assert.IsType<Product>(okResult.Value);
      Assert.Equal(product, model);
    }

    [Fact]
    public void Remove_Product_Shoppingcart_ReturnsOkResult_WithUpdatedCustomer()
    {
      // Arrange
      var customerId = Guid.NewGuid();
      var customer = new UserCustomer { Id = customerId };
      var product = new Product { Id = Guid.NewGuid() };
      var mockCustomerRepository = new Mock<IUserCustomerInterface>();
      mockCustomerRepository.Setup(repo => repo.GetUserCustomerById(customerId)).Returns(customer);
      var mockCustomerService = new Mock<CarshoppingServiceInterface>();
      mockCustomerService.Setup(repo => repo.RemoveProduct(customerId, product.Id)).Returns(true);
      var customerController = new UserCustomerController(mockCustomerRepository.Object, mockCustomerService.Object);

      // Act
      var result = customerController.RemoveProduct(customerId, product.Id);

      // Assert
      var okResult = Assert.IsType<OkObjectResult>(result);
      var model = Assert.IsType<bool>(okResult.Value);
      Assert.Equal(true, model);
    }

    [Fact]
    public void GetShoppingCart_ReturnsOkResult_WithShoppingCart()
    {
      // Arrange
      var customerId = Guid.NewGuid();
      var customer = new UserCustomer { Id = customerId };
      var shoppingCart = new ShoppingCar { Id = Guid.NewGuid() };
      var mockCustomerRepository = new Mock<IUserCustomerInterface>();
      mockCustomerRepository.Setup(repo => repo.GetUserCustomerById(customerId)).Returns(customer);
      var mockCustomerService = new Mock<CarshoppingServiceInterface>();
      mockCustomerService.Setup(repo => repo.GetShoppingCarById(customerId)).Returns(shoppingCart);
      var customerController = new UserCustomerController(mockCustomerRepository.Object, mockCustomerService.Object);

      // Act
      var result = customerController.GetShoppingCarById(customerId);

      // Assert
      var okResult = Assert.IsType<OkObjectResult>(result);
      var model = Assert.IsType<ShoppingCar>(okResult.Value);
      Assert.Equal(shoppingCart, model);
    }

    [Fact]
    public void UpdateProduct_Quantify_Shoppingcart_ReturnsOkResult_WithUpdatedShoppingCart()
    {
      // Arrange
      var customerId = Guid.NewGuid();
      var customer = new UserCustomer { Id = customerId };
      var shoppingCart = new ShoppingCar { Id = Guid.NewGuid() };
      var product = new Product { Id = Guid.NewGuid() };
      var mockCustomerRepository = new Mock<IUserCustomerInterface>();
      mockCustomerRepository.Setup(repo => repo.GetUserCustomerById(customerId)).Returns(customer);
      var mockCustomerService = new Mock<CarshoppingServiceInterface>();
      mockCustomerService.Setup(repo => repo.UpdateProductQuantify(customerId, product.Id, 10)).Returns(product);
      var customerController = new UserCustomerController(mockCustomerRepository.Object, mockCustomerService.Object);

      // Act
      var result = customerController.UpdateQuantity(customerId, product.Id, 10);

      // Assert
      var okResult = Assert.IsType<OkObjectResult>(result);
      var model = Assert.IsType<Product>(okResult.Value);
      Assert.Equal(product, model);
    }
  }
}