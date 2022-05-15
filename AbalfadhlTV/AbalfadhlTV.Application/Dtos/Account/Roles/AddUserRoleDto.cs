using Microsoft.AspNetCore.Mvc.Rendering;

namespace AbalfadhlTV.Application.Dtos.Account.Roles
{
    public class AddUserRoleDto
    {
        public long UserId { get; set; }
        public string Role { get; set; }
       // public List<SelectListItem> Roles { get; set; }
    }
}
