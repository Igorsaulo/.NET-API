using Ecomerce.Models;

public class UserSeller : User
{
    public Guid Id { get; set; }
    public int UserSellerId { get; set; }
    public List<SaleProduct> Sales { get; set; }
    public int TotalSales { get; set; }
}