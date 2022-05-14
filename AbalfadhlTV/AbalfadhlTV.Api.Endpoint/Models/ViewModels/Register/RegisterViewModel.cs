using System.ComponentModel.DataAnnotations;

namespace AbalfadhlTV.Api.Endpoint.Models.ViewModels.Register
{
    public class RegisterViewModel
    {
       
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public string Username { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}
