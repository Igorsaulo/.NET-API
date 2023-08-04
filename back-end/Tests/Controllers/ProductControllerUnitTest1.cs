using System;
using System.Collections.Generic;
using Xunit;
using Moq;
using Ecomerce.Controllers;
using Ecomerce.Repositories;
using Ecomerce.Repositories.Interfaces;
using Ecomerce.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ecomerce.Tests
{
  public class ProductControllerUnitTest1
  {
    List<Product> products = new List<Product>
            {
                new Product {
                  Id = new Guid(),
                  Name = "Product 1",
                  Price = 10.10M,
                  Quantity = 10 ,
                  Description = "Description 1",
                  Category = "Category 1",
                  Images = new List<string>(){"Image 1"},
                  Characteristics = new Dictionary<string, string>(){
                    {"key1","value1"},
                    {"key2","value2"},
                    {"key3","value3"}
                  }
                },
                new Product {
                  Id = new Guid(),
                  Name = "Product 2",
                  Price = 20.20M,
                  Quantity = 20 ,
                  Description = "Description 2",
                  Category = "Category 2",
                  Images = new List<string>(){"Image 2"},
                  Characteristics = new Dictionary<string, string>(){
                    {"key1","value1"},
                    {"key2","value2"},
                    {"key3","value3"}
                  }
                },
                new Product {
                  Id = new Guid(),
                  Name = "Product 3",
                  Price = 30.30M,
                  Quantity = 30 ,
                  Description = "Description 3",
                  Category = "Category 3",
                  Images = new List<string>(){"Image 3"},
                  Characteristics = new Dictionary<string, string>(){
                    {"key1","value1"},
                    {"key2","value2"},
                    {"key3","value3"}
                  }
                }
            };
    private readonly Mock<IProductRepository> mock = new Mock<IProductRepository>();

    [Fact]
    public void GetAllProductsTest()
    {
      // Arrange
      mock.Setup(repo => repo.GetAll()).Returns(products);
      var controller = new ProductController(mock.Object);

      // Act
      var result = controller.GetAll();

      // Assert
      var okResult = Assert.IsType<OkObjectResult>(result);
      var returnProducts = Assert.IsType<List<Product>>(okResult.Value);
      Assert.Equal(3, returnProducts.Count);
    }

    [Fact]
    public void GetByIdTest()
    {
      // Arrange
      mock.Setup(repo => repo.GetProductById(products[0].Id)).Returns(products[0]);
      var controller = new ProductController(mock.Object);

      // Act
      var result = controller.GetById(products[0].Id);

      // Assert
      var okResult = Assert.IsType<OkObjectResult>(result);
      var returnProduct = Assert.IsType<Product>(okResult.Value);
      Assert.Equal(products[0].Id, returnProduct.Id);
    }

    [Fact]
    public void PostProductTest()
    {
      // Arrange
      mock.Setup(repo => repo.SaveProduct(products[0])).Returns(true);
      var controller = new ProductController(mock.Object);

      // Act
      var result = controller.Post(products[0]);

      // Assert
      var okResult = Assert.IsType<OkObjectResult>(result);
      var returnProduct = Assert.IsType<Product>(okResult.Value);
      Assert.Equal(products[0].Id, returnProduct.Id);
    }

    [Fact]
    public void PutProductTest()
    {
      // Arrange
      mock.Setup(repo => repo.UpdateProduct(products[0])).Returns(true);
      var controller = new ProductController(mock.Object);

      // Act
      var result = controller.Put(products[0]);

      // Assert
      var okResult = Assert.IsType<OkObjectResult>(result);
      var returnProduct = Assert.IsType<Product>(okResult.Value);
      Assert.Equal(products[0].Id, returnProduct.Id);
    }

    [Fact]
    public void DeleteProductTest()
    {
      // Arrange
      mock.Setup(repo => repo.DeleteProduct(products[0].Id)).Returns(true);
      var controller = new ProductController(mock.Object);

      // Act
      var result = controller.Delete(products[0].Id);

      // Assert
      var okResult = Assert.IsType<OkObjectResult>(result);
      var returnProduct = Assert.IsType<Boolean>(okResult.Value);
      Assert.Equal(true, returnProduct);
    }
  }
}
