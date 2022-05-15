using System.ComponentModel.DataAnnotations;

namespace AbalfadhlTV.Api.Endpoint.Models.ViewModels.Register
{
    public class LoginViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

    }
}
