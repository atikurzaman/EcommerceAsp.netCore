using Application.Identity;
using Application.Persistence.EntityConfigurations.Membership;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Persistence
{
    public class ApplicationDbContext : IdentityDbContext<User,Role,long>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);  

            //builder.ApplyConfiguration(new UserMap());
            //builder.ApplyConfiguration(new RoleMap());
            //builder.ApplyConfiguration(new UserRoleMap());
            //builder.ApplyConfiguration(new UserLoginMap());
            //builder.ApplyConfiguration(new UserClaimMap());
            //builder.ApplyConfiguration(new RoleClaimMap());
            //builder.ApplyConfiguration(new UserTokenMap());
        }
    }
}
