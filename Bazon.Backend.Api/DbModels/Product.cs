namespace Bazon.Backend.Api.DbModels;

public class Product
{
    public int Id { get; set; }
    public string Reference { get; set; }
    public string Name { get; set; }
    public string Brand { get; set; }
    public string Description { get; set; }
    public string Unit { get; set; }
    public string Warranty { get; set; }
    public string Barcode { get; set; }
    public string Tnved { get; set; }
    public double Volume { get; set; }
    public double Size { get; set; }
    public decimal Price { get; set; }
}