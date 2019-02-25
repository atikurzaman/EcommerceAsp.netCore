using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Entities
{
    //
    // Summary:
    //     Represents the link between a user and a role.
    //
    // Type parameters:
    //   TKey:
    //     The type of the primary key used for users and roles.
    public class AppUserRole
    {
        public AppUserRole()
        {
        }
        //
        // Summary:
        //     Gets or sets the primary key of the user that is linked to a role.
        public long UserId { get; set; }
        //
        // Summary:
        //     Gets or sets the primary key of the role that is linked to the user.
        public long RoleId { get; set; }
    }
}
