namespace Bazon.Backend.Api.Models;

public class Company
{
    public int Id { get; set; }
    public string Name { get; set; }
    public User Owner { get; set; }
    
}