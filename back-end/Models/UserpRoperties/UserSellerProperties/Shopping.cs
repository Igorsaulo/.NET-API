namespace Ecomerce.Models
{
    public class Shopping
    {
        public Guid Id { get; set; }
        public Product Product { get; set; }
        public Delivery Delivery { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime ShoppingDate { get; set; }

        // Foreign Keys
        public Guid UserId { get; set; }

        public User User { get; set; }
    }
}
