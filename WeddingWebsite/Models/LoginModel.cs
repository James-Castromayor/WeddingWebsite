using System.ComponentModel.DataAnnotations;

namespace WeddingWebsite.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Please enter your name")]
        public string Username { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter the wedding password")]
        public string Password { get; set; } = string.Empty;
    }
}
