using Ecomerce.Models;

public class UserCustomer : User
{     
    public string Id { get; set; }
     public int UserCustomerId { get; set; }
     public int shoppingCarId { get; set; }
     public List<ShoppingCar> ShoppingCar { get; set; }
}
