using Microsoft.AspNetCore.Identity;

namespace UsersApp.Models
{
    public class Users : IdentityUser
    {
        public string FullName { get; set; }
    }
}
