using System.ComponentModel.DataAnnotations;

namespace AbalfadhlTV.Api.Endpoint.Models.ViewModels.Register
{
    public class LoginViewModel
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

    }
}
