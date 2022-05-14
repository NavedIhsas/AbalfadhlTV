using Microsoft.AspNetCore.Mvc.Rendering;

namespace AbalfadhlTV.Application.Dtos.Account.Roles
{
    public class AddUserRoleDto
    {
        public string Email { get; set; }
        public long Id { get; set; }
        public string Role { get; set; }
        public List<SelectListItem> Roles { get; set; }
    }
}
