using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace Application.Identity
{
    public class User: IdentityUser<long>
    {
        //public ICollection<UserRole> UserRoles { get; set; }
    }
}
