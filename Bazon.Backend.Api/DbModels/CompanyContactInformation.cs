namespace Bazon.Backend.Api.DbModels;

public class CompanyContactInformation
{
    public int Id { get; set; }
    public string Type { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public string ContactReference { get; set; }
    public int Priority { get; set; }
    
}