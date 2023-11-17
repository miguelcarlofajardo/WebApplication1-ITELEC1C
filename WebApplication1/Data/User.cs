using Microsoft.AspNetCore.Identity;

namespace WebApplication1.Data
{
    public class User : IdentityUser
    {
        public string? Firstname {  get; set; }
        public string? Lastname { get; set;}
    }
}
