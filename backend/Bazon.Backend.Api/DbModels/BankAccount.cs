namespace Bazon.Backend.Api.DbModels;

public class BankAccount
{
    public int Id { get; set; }
    public string BankName { get; set; }
    public string Bic { get; set; }
    public string SwiftAccount { get; set; }
    public string UserAccount { get; set; }
    public string OwnerName { get; set; }
    public string SocialSecurityNumber { get; set; }
    public string Kpp { get; set; }
}