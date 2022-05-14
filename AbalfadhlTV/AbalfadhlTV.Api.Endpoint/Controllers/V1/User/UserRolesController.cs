using AbalfadhlTV.Application.Dtos.Account.Roles;
using AbalfadhlTV.infrastructure.ConstMessages;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AbalfadhlTV.Api.Endpoint.Controllers.V1.User
{
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/user/Roles")]
    [ApiController]
    public class UserRolesController : ControllerBase
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<IdentityUser> _userManager;

        public UserRolesController(RoleManager<IdentityRole> roleManager, UserManager<IdentityUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }


        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

       
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var user =await _userManager.FindByIdAsync(id.ToString());
            if (user == null) return new JsonResult(ErrorMessage.RecordNotFount);
            var roles =await _userManager.GetRolesAsync(user);
           
            return Ok(roles);

        }


        [HttpPost]
        public async Task<IActionResult> Post([FromBody] AddUserRoleDto newRole)
        {
            var user =await _userManager.FindByIdAsync(newRole.Id.ToString());
            if (user == null) return new JsonResult(ErrorMessage.RecordNotFount);

            var result =await _userManager.AddToRoleAsync(user, newRole.Role);
            return Created("", result);
        }

        // PUT api/<UserRoleController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UserRoleController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
