using AbalfadhlTV.Api.Endpoint.Models.ViewModels.Register;
using AbalfadhlTV.Application.Dtos.Account.Users;
using AbalfadhlTV.Common.Contracts;
using AbalfadhlTV.infrastructure.ConstMessages;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;


namespace AbalfadhlTV.Api.Endpoint.Controllers.V1.User
{
    [ApiVersion("1")]

    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserManager<IdentityUser<long>> _userManager;

        public UserController(UserManager<IdentityUser<long>> userManager)
        {
            _userManager = userManager;
        }

       
        [HttpGet]
        public  IActionResult Get()
        {
            var users =  _userManager.Users
                .Select(p => new UserListDto
                {
                    Id = p.Id,
                    Email = p.Email,
                    Links = new List<Link>()
                    {
                        new Link(){ Href = Url.Action(nameof(Get),"User",new {p.Id},Request.Scheme),Method = "Get",Ref = "Self"},
                        new Link() {Href = Url.Action(nameof(Put),"User",Request.Scheme),Method = "Put",Ref = "Update"},
                        new Link() {Href = Url.Action(nameof(Delete),"User",new {p.Id},Request.Scheme),Method = "DELETE",Ref ="delete"},
                        new Link() {Href = Url.Action(nameof(Get),"UserRoles",new {userId=p.Id},Request.Scheme),Method = "Get",Ref = "Self"},
                        new Link() {Href = Url.Action(nameof(Post),"UserLogin",Request.Scheme),Method = "Get",Ref = "Self"},
                    }
                }).ToList();
            return Ok(users);
        }


        //ToDo
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(long id)
        {
            var findUser =await _userManager.FindByIdAsync(id.ToString());
            if (findUser == null) return new JsonResult(ErrorMessage.RecordNotFount);

            var user = new UserDto
            {
                Email = findUser.Email,
                Id = findUser.Id,
            };
            return Ok(user);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] RegisterViewModel command)
        {
            if (!ModelState.IsValid) return BadRequest();

            var user = new IdentityUser<long>
            {
                Email = command.Email,
                UserName = command.Email,
            };

            var result =await _userManager.CreateAsync(user, command.Password);

            var pasUser = new UserDto
            {
                Id = user.Id,
                Email = user.Email,
            };
            var url = Url.Action(nameof(Get), "User", new {Id = user.Id}, Request.Scheme);
            if (result.Succeeded) return Created(url ?? string.Empty, pasUser);

            else
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(error.Code, error.Description);
                    return new JsonResult(error.Description);
                }

                return BadRequest();
            }

        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] UserEditDto userEdit)
        {
            var user = await _userManager.FindByIdAsync(userEdit.Id.ToString());
            if (user == null) return new JsonResult(ErrorMessage.RecordNotFount);
            user.Email = userEdit.Email;
            user.UserName = userEdit.Email;

            var result =await _userManager.UpdateAsync(user);

            var customUser = new UserDto
            {
                Id = user.Id,
                Email = user.Email
            };
            if (result.Succeeded) return Ok(customUser);
            
            foreach (var item in result.Errors.ToList())
            {
                return new JsonResult(item.Description);
            }

            return BadRequest();
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {

            var user =await _userManager.FindByIdAsync(id.ToString());
            if (user == null) return new JsonResult(ErrorMessage.RecordNotFount);

            var result =await _userManager.DeleteAsync(user);

            if (result.Succeeded) return Ok();
            

            foreach (var item in result.Errors.ToList())
                return new JsonResult(item.Description);



            return BadRequest();
        }
    }
}
