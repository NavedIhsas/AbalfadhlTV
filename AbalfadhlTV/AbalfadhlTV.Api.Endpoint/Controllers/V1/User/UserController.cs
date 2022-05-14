using AbalfadhlTV.Api.Endpoint.Models.ViewModels.Register;
using AbalfadhlTV.Application.Dtos.Account.Users;
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
        private readonly UserManager<IdentityUser> _userManager;

        public UserController(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

       
        [HttpGet]
        public  IActionResult Get()
        {
            var users =  _userManager.Users
                .Select(p => new UserListDto
                {
                    Id = Convert.ToInt64(p.Id),
                    UserName = p.UserName,
                    Email = p.Email,
                }).ToList();
            return Ok(users);
        }


        //ToDo
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] RegisterViewModel command)
        {
            if (!ModelState.IsValid) return BadRequest();

            var user = new IdentityUser
            {
                UserName = command.Username,
                Email = command.Email,
            };

            var result =await _userManager.CreateAsync(user, command.Password);
            if (result.Succeeded) return Ok();

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
            user.UserName = userEdit.UserName;

            var result =await _userManager.UpdateAsync(user);

            if (result.Succeeded) return Ok(user);
            
            foreach (var item in result.Errors.ToList())
            {
                return new JsonResult(item.Description);
            }

            return BadRequest();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromBody] long id)
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
