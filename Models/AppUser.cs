using Microsoft.AspNetCore.Identity;

namespace ProductsAPI.Models
{
    public class AppUser:IdentityUser<int>
    {
        public string FullNAme {get;set;}=null!;
        public DateTime DateAdded {get;set;}
    }
}