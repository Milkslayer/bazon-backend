namespace Bazon.Backend.Api.DbModels;

public class Group
{
    public int Id { get; set; }
    public string Name { get; set; }
    public virtual ICollection<GroupUser> GroupUsers { get; set; }
}