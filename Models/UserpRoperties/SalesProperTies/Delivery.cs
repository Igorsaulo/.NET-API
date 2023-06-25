public class DeliveryProperties
{  
    public Guid Id { get; set; }
    public int DeliveryId { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }
    public DateTime DeliveryDate { get; set; }
    public DateTime PreviewDate { get; set; }
    public string DeliveryStatus { get; set; }
}
