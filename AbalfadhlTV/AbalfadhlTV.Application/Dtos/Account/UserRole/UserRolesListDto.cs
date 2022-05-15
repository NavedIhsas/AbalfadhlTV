
using AbalfadhlTV.Common.Contracts;

namespace AbalfadhlTV.Application.Dtos.Account.UserRole
{
    public class UserRolesListDto
    {
        public long Id { get; set; }
        public string Email { get; set; }
        public List<Link> Links { get; set; }
    }
}
