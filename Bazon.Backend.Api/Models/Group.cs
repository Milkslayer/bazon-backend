﻿namespace Bazon.Backend.Api.Models;

public class Group
{
    public int Id { get; set; }
    public string Name { get; set; }
    public virtual ICollection<GroupUser> GroupUsers { get; set; }
}