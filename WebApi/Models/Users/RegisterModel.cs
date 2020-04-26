using System.ComponentModel.DataAnnotations;

namespace WebApi.Models.Users
{
    public class RegisterModel
    {
        [Required]
        public string MobileNumber { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string DoB { get; set; }
        public string Gender { get; set; } 
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}