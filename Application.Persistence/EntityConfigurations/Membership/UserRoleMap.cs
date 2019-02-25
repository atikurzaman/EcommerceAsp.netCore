using Application.Entities;
using Application.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Application.Persistence.EntityConfigurations.Membership
{
    public class UserRoleMap : IEntityTypeConfiguration<UserRole>
    {
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {
            // Primary key
            builder.HasKey(ur => new { ur.UserId, ur.RoleId });

            // Maps to the UserRole table
            builder.ToTable("UserRole");

            //builder.HasOne(ur => ur.Role)
            //    .WithMany(r => r.UserRoles)
            //    .HasForeignKey(ur => ur.RoleId)
            //    .IsRequired();

            //builder.HasOne(ur => ur.User)
            //    .WithMany(r => r.UserRoles)
            //    .HasForeignKey(ur => ur.UserId)
            //    .IsRequired();
        }
    }
}
