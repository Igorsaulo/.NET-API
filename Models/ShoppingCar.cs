namespace Ecomerce.Models
{
    public class ShoppingCar
    {
        public Guid Id { get; set; }
        public int ShoppingCarId { get; set; }
        public List<ProductModel> Products { get; set; }
        public double Total { get; set; }
        public int Quantify { get; set; }
        public UserModel User { get; set; }
    }
}