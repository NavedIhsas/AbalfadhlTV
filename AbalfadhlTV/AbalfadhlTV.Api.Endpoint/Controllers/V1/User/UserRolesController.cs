using AbalfadhlTV.Application.Dtos.Account.Roles;
using AbalfadhlTV.Application.Dtos.Account.UserRole;
using AbalfadhlTV.Common.Contracts;
using AbalfadhlTV.infrastructure.ConstMessages;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;


namespace AbalfadhlTV.Api.Endpoint.Controllers.V1.User
{
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/user/Roles")]
    [ApiController]
    public class UserRolesController : ControllerBase
    {
        private readonly UserManager<IdentityUser<long>> _userManager;
        private readonly RoleManager<IdentityRole<long>> _roleManager;
        public UserRolesController(UserManager<IdentityUser<long>> userManager, RoleManager<IdentityRole<long>> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }


        [HttpGet]
        public async Task<IActionResult> Get(string roleName)
        {
            var userRoles = await _userManager.GetUsersInRoleAsync(roleName);
            if (userRoles == null) return new JsonResult(ErrorMessage.RecordNotFount);
            var customUserRoles = userRoles.Select(x => new UserRolesListDto
            {

                Id = x.Id,
                Email = x.Email,
                Links = new List<Link>()
                {
                    new Link()
                    {
                        Href = Url.Action(nameof(Get), "UserRoles", new {userId=x.Id}, Request.Scheme),
                        Method = "Get", Ref = "Self"
                    },
                    //new Link() {Href = Url.Action(nameof(Put), "UserRoles", Request.Scheme), Method = "Put", Ref = "Update"},
                    //new Link()
                    //{
                    //    Href = Url.Action(nameof(Delete), "UserRoles", new {x.Id}, Request.Scheme), Method = "DELETE",
                    //    Ref = "delete"
                    //},
                }
            });

            return Ok(customUserRoles);
        }


        [HttpGet("{userId}")]
        public async Task<IActionResult> Get(long userId)
        {
            var user = await _userManager.FindByIdAsync(userId.ToString());
            if (user == null) return new JsonResult(ErrorMessage.RecordNotFount);
            var roles = await _userManager.GetRolesAsync(user);

            return Ok(roles);

        }


        [HttpPost]
        public async Task<IActionResult> Post([FromBody] AddUserRoleDto newRole)
        {
            var user = await _userManager.FindByIdAsync(newRole.UserId.ToString());
            if (user == null) return new JsonResult(ErrorMessage.RecordNotFount);

            var role =await _roleManager.FindByNameAsync(newRole.Role);

            if (role == null) return new JsonResult(ErrorMessage.RoleNameNotExist);

            var result = await _userManager.AddToRoleAsync(user, newRole.Role);

            var url = Url.Action(nameof(Get), "UserRoles", new { userId = user.Id }, Request.Scheme);

            if (result.Succeeded)
                return Created(url ?? string.Empty, result);

            foreach (var identityError in result.Errors)
                return new JsonResult(identityError.Description);

            return BadRequest();
        }


        //[HttpPut()]
        //public void Put( [FromBody] string value)
        //{
        //}


        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
