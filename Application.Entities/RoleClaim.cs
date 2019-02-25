using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;

namespace Application.Entities
{
    //
    // Summary:
    //     Represents a claim that is granted to all users within a role.
    //
    // Type parameters:
    //   TKey:
    //     The type of the primary key of the role associated with this claim.
    public class AppRoleClaim
    {
        public AppRoleClaim()
        {
        }
        //
        // Summary:
        //     Gets or sets the identifier for this role claim.
        public long Id { get; set; }
        //
        // Summary:
        //     Gets or sets the of the primary key of the role associated with this claim.
        public long RoleId { get; set; }
        //
        // Summary:
        //     Gets or sets the claim type for this claim.
        public string ClaimType { get; set; }
        //
        // Summary:
        //     Gets or sets the claim value for this claim.
        public string ClaimValue { get; set; }

        public AppRole Role { get; set; }
    }
}
