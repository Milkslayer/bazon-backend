namespace Bazon.Backend.Api.DbModels;

public class UserAddress
{
    public int Id { get; set; }
    public string StreetName { get; set; }
    public string City { get; set; }
    public string Region { get; set; }
    public string ZipCode { get; set; }
    public string Country { get; set; }
}