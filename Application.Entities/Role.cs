using System.Collections.Generic;

namespace Application.Entities
{
    //
    // Summary:
    //     Represents a role in the identity system
    //
    // Type parameters:
    //   TKey:
    //     The type used for the primary key for the role.
    public class AppRole
    {
        //
        // Summary:
        //     Initializes a new instance of Role.
        public AppRole()
        {
        }
        //
        // Summary:
        //     Initializes a new instance of Role.
        //
        // Parameters:
        //   roleName:
        //     The role name.
        public AppRole(string roleName)
        {
        }
        //
        // Summary:
        //     Gets or sets the primary key for this role.
        public  long Id { get; set; }
        //
        // Summary:
        //     Gets or sets the name for this role.
        public  string Name { get; set; }
        //
        // Summary:
        //     Gets or sets the normalized name for this role.
        public  string NormalizedName { get; set; }
        //
        // Summary:
        //     A random value that should change whenever a role is persisted to the store
        public  string ConcurrencyStamp { get; set; }
        public ICollection<AppUserRole> UserRoles { get; set; }
        public ICollection<AppRoleClaim> RoleClaims { get; set; }
    }
}
