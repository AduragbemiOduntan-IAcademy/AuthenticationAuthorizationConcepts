using Microsoft.AspNetCore.Identity;

namespace AuthenticationAuthorizationConcepts.Domain.Entities
{
    public class User : IdentityUser
    {
        public int UserId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
