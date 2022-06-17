using Microsoft.AspNetCore.Identity;

namespace ChatApp.Models
{
    public class User : IdentityUser
    {
        public DateTime Year { get; set; }
    }
}
