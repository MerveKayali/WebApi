using System.ComponentModel.DataAnnotations;

namespace ProductsAPI.ProductDTO
{
    public class UserDTO
    {
        [Required]
        public string FullNAme {get; set;}=null!;
        public string UserName {get; set;}=null!;
        public string Email {get; set;}=null!;
        public string Password {get; set;}=null!;

    }
}