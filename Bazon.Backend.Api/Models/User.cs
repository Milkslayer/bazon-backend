namespace Bazon.Backend.Api.Models;

public class User
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string? Patronymic { get; set; }
    public DateTime Dob { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string PasswordDigest { get; set; }
    public DateTime CreatedAt { get; set; }
    
    public List<UserAddress> Addresses {get; set; }

    public virtual ICollection<GroupUser> GroupUsers { get; set; }
}