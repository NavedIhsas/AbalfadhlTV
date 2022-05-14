namespace AbalfadhlTV.Application.Dtos.Account.Roles
{
    public class AddNewRoleDto
    {
        public string Name { get; set; }
    }

    public class EditRoleDto : AddNewRoleDto
    {
        public long Id { get; set; }
    }
}
