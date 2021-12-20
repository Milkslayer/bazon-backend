namespace Bazon.Backend.Api.DbModels;

public class Order
{
    public int Id { get; set; }
    public string OrderNumber { get; set; }
    public DateTime OrderDate { get; set; }
    public string ProductReference { get; set; }
    public string ProductName { get; set; }
    public decimal TotalPrice { get; set; }
    public decimal Discount { get; set; }
    public string ReceiptNumber { get; set; }
    public string CheckoutNumber { get; set; }
    public string ShippingMethod { get; set; }
    public TimeSpan ProcessingTime { get; set; }
}