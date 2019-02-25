using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Entities
{
    //
    // Summary:
    //     Represents a claim that a user possesses.
    //
    // Type parameters:
    //   TKey:
    //     The type used for the primary key for this user that possesses this claim.
    public class AppUserClaim
    {
        public AppUserClaim()
        {
        }
        //
        // Summary:
        //     Gets or sets the identifier for this user claim.
        public long Id { get; set; }
        //
        // Summary:
        //     Gets or sets the primary key of the user associated with this claim.
        public long UserId { get; set; }
        //
        // Summary:
        //     Gets or sets the claim type for this claim.
        public string ClaimType { get; set; }
        //
        // Summary:
        //     Gets or sets the claim value for this claim.
        public string ClaimValue { get; set; }       
    }
}
