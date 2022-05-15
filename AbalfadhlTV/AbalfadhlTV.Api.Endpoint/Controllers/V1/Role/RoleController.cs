using AbalfadhlTV.Application.Dtos.Account.Roles;
using AbalfadhlTV.Common.Contracts;
using AbalfadhlTV.infrastructure.ConstMessages;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AbalfadhlTV.Api.Endpoint.Controllers.V1.Role
{
    [ApiVersion("1")]

    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly RoleManager<IdentityRole<long>> _roleManager;
        private readonly UserManager<IdentityUser<long>> _userManager;
        public RoleController(RoleManager<IdentityRole<long>> roleManager, UserManager<IdentityUser<long>> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }


        [HttpGet]
        public IActionResult Get()
        {
            var roles = _roleManager.Roles
                .Select(p =>
                    new RoleListDto
                    {
                        Id = p.Id,
                        Name = p.Name,
                        Links = new List<Link>()
                        {
                            new Link()
                            {
                                Href = Url.Action(nameof(Get), "Role", new {p.Id}, Request.Scheme), Method = "Get",
                                Ref = "self"
                            },
                            new Link() {Href = Url.Action(nameof(Put), "Role", Request.Scheme), Method = "Put", Ref = "update"},
                            new Link()
                            {
                                Href = Url.Action(nameof(Delete), "Role", new {p.Id}, Request.Scheme), Method = "DELETE",
                                Ref = "delete"
                            }
                        }
                    }).ToList();

            return Ok(roles);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var role = await _roleManager.FindByIdAsync(id.ToString());
            if (role == null) return new JsonResult(ErrorMessage.RecordNotFount);

            return Ok(role);
        }


        [HttpPost]
        public IActionResult Post([FromBody] AddNewRoleDto newRole)
        {

            var role = new IdentityRole<long>() { Name = newRole.Name, };

            var result = _roleManager.CreateAsync(role).Result;

            var url = Url.Action(nameof(Get), "Role", new { role.Id }, Request.Scheme);

            if (result.Succeeded) return Created(url ?? string.Empty, role);

            var errors = result.Errors.ToList();

            foreach (var list in errors)
                return new JsonResult(list.Description);

            return new JsonResult(role);
        }

        [HttpPut()]
        public async Task<IActionResult> Put([FromBody] EditRoleDto command)
        {
            var role = await _roleManager.FindByIdAsync(command.Id.ToString());
            if (role == null) return new JsonResult(ErrorMessage.RecordNotFount);

            role.Name = command.Name;
            var update = await _roleManager.UpdateAsync(role);
            if (update.Succeeded) return Ok(role);

            else
            {
                var errors = update.Errors.ToList();

                foreach (var list in errors)
                    return new JsonResult(list.Description);

                return BadRequest();
            }

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            var role = await _roleManager.FindByIdAsync(id.ToString());
            if (role == null) return new JsonResult(ErrorMessage.RecordNotFount);
            await _roleManager.DeleteAsync(role);
            return Ok();
        }
    }
}
