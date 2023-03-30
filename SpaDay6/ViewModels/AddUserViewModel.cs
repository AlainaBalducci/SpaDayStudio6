using System.ComponentModel.DataAnnotations;

namespace SpaDay6.ViewModels
{
    public class AddUserViewModel
    {
        [Required(ErrorMessage = "Please enter your username")]
        [StringLength(15, MinimumLength = 5, ErrorMessage = "Your username must be between 5 and 15 characters long")]
        public string? Username { get; set; }

        [EmailAddress]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Please enter your password")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Your password must be between 6 and 20 characters long")]
        public string? Password { get; set; }

        [Required(ErrorMessage = "Please verify your password")]
        public string? VerifyPassword { get; set; }
    }
}
