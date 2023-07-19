namespace Ecomerce.Models
{
    public class SaleProduct
    {
        public Guid Id { get; set; }
        public Product Product { get; set; }
        public Delivery Delivery { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime ShoppingDate { get; set; }

        // Foreign Keys
        public Guid CustomerId { get; set; }
        public Guid SellerId { get; set; }
        public UserSeller Seller { get; set; }
        public UserCustomer Customer { get; set; }
    }
}
