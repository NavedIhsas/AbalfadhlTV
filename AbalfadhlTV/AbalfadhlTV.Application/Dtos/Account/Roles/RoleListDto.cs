using AbalfadhlTV.Common.Contracts;

namespace AbalfadhlTV.Application.Dtos.Account.Roles
{
    public class RoleListDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public List<Link> Links { get; set; }

    }
}
