using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bazon.Backend.Api.DbModels;

public class BazonContext : DbContext
{
    public BazonContext(DbContextOptions<BazonContext> options) : base(options)
    { }
    public DbSet<User> Users { get; set; }
    public DbSet<UserAddress> UserAddress { get; set; }
    public DbSet<Group> Groups { get; set; }
    public DbSet<GroupUser> GroupUsers { get; set; }

    public string ToSnakeCase(string str)
    {
        StringBuilder sb = new StringBuilder();
        sb.Append(char.ToLower(str[0]));
        foreach (char c in str[1..])
        {
            if (char.IsUpper(c))
            {
                sb.Append('_');
                sb.Append(char.ToLowerInvariant(c));
            }
            else
            {
                sb.Append(c);
            }
        }

        return sb.ToString();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>(entity =>
        {
            RelationalEntityTypeBuilderExtensions.ToTable((EntityTypeBuilder) entity, "user");
            entity.HasMany(u => u.Addresses);
        });
        
        modelBuilder.Entity<UserAddress>(entity =>
        {
            entity.ToTable("address");
        });
        
        modelBuilder.Entity<Group>(entity =>
        {
            entity.ToTable("group");
        });

        modelBuilder.Entity<GroupUser>(entity =>
        {
            entity.ToTable("group_users");

            entity.HasKey(c => new {c.GroupId, c.UserId});
            entity.HasOne(gu => gu.Group)
                .WithMany(g => g.GroupUsers)
                .HasForeignKey(gu => gu.GroupId)
                .IsRequired();
            entity.HasOne(gu => gu.User)
                .WithMany(u => u.GroupUsers)
                .HasForeignKey(gu => gu.UserId)
                .IsRequired();
        });

        foreach (var entity in modelBuilder.Model.GetEntityTypes())
        {
            foreach (var property in entity.GetProperties())
            {
                property.SetColumnName(ToSnakeCase(property.Name));
            }
        }
    }
}