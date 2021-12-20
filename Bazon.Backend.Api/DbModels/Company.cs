namespace Bazon.Backend.Api.DbModels;

public class Company
{
    public int Id { get; set; }
    public string Name { get; set; }
    public User Owner { get; set; }
    public string FullName { get; set; }
}