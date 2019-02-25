using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Entities
{
    //
    // Summary:
    //     Represents a user in the identity system
    //
    // Type parameters:
    //   TKey:
    //     The type used for the primary key for the user.
    public class AppUser
    {
        //
        // Summary:
        //     Initializes a new instance of User.
        public AppUser()
        {
        }
        //
        // Summary:
        //     Initializes a new instance of User.
        //
        // Parameters:
        //   userName:
        //     The user name.
        public AppUser(string userName)
        {
        }
        //
        // Summary:
        //     Gets or sets the primary key for this user.
        [PersonalData]
        public long Id { get; set; }
        //
        // Summary:
        //     Gets or sets the date and time, in UTC, when any user lockout ends.
        //
        // Remarks:
        //     A value in the past means the user is not locked out.
        public DateTimeOffset? LockoutEnd { get; set; }
        //
        // Summary:
        //     Gets or sets a flag indicating if two factor authentication is enabled for this
        //     user.
        [PersonalData]
        public bool TwoFactorEnabled { get; set; }
        //
        // Summary:
        //     Gets or sets a flag indicating if a user has confirmed their telephone address.
        [PersonalData]
        public bool PhoneNumberConfirmed { get; set; }
        //
        // Summary:
        //     Gets or sets a telephone number for the user.
        [ProtectedPersonalData]
        public string PhoneNumber { get; set; }        
        //
        // Summary:
        //     Gets or sets a salted and hashed representation of the password for this user.
        public string PasswordHash { get; set; }
        //
        // Summary:
        //     Gets or sets a flag indicating if a user has confirmed their email address.
        [PersonalData]
        public bool EmailConfirmed { get; set; }        
        //
        // Summary:
        //     Gets or sets the email address for this user.
        [ProtectedPersonalData]
        public string Email { get; set; }
        //
        // Summary:
        //     Gets or sets the normalized user name for this user.        
        [ProtectedPersonalData]
        public string UserName { get; set; }        
        //
        // Summary:
        //     Gets or sets a flag indicating if the user could be locked out.
        public bool LockoutEnabled { get; set; }
        //
        // Summary:
        //     Gets or sets the number of failed login attempts for the current user.
        public int AccessFailedCount { get; set; }
        //
        // Summary:
        //     A random value that must change whenever a user is persisted to the store
        public virtual string ConcurrencyStamp { get; set; }
    }
}
