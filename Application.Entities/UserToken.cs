using Microsoft.AspNetCore.Identity;

namespace Application.Entities
{
    //
    // Summary:
    //     Represents an authentication token for a user.
    //
    // Type parameters:
    //   TKey:
    //     The type of the primary key used for users.
    public class AppUserToken
    {
        public AppUserToken()
        {
        }
        //
        // Summary:
        //     Gets or sets the primary key of the user that the token belongs to.
        public long UserId { get; set; }
        //
        // Summary:
        //     Gets or sets the LoginProvider this token is from.
        public string LoginProvider { get; set; }
        //
        // Summary:
        //     Gets or sets the name of the token.
        public string Name { get; set; }
        //
        // Summary:
        //     Gets or sets the token value.
        [ProtectedPersonalData]
        public string Value { get; set; }
    }
}
