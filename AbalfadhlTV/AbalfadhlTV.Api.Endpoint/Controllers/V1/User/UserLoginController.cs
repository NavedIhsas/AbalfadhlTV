using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using AbalfadhlTV.Api.Endpoint.Models.ViewModels.Register;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace AbalfadhlTV.Api.Endpoint.Controllers.V1.User
{
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/user/login")]
    [ApiController]
    public class UserLoginController : ControllerBase
    {

        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly IConfiguration _configuration;
        public UserLoginController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, IConfiguration configuration)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            this._configuration = configuration;
        }
  

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] LoginViewModel command)
        {
            if (!ModelState.IsValid) return new JsonResult("فیلد های مورد نیاز را پر کنید");

            var user = await _userManager.FindByNameAsync(command.Username);
            if (user == null) return new JsonResult("کاربری با این نام کاربری ثبت نام نکرده است");

           await _signInManager.SignOutAsync();
            var result =await _signInManager.PasswordSignInAsync(user, command.Password,false,true);
            if (!result.Succeeded) return new JsonResult("کاربری با این مشخصات وجود ندارد");

            var claims = new List<Claim>
                    {
                        new Claim (ClaimTypes.Email,command.Username),
                    };
            var key = _configuration["JWtConfig:Key"];
            var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));
            var credentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: _configuration["JWtConfig:issuer"],
                audience: _configuration["JWtConfig:audience"],
                expires: DateTime.Now.AddMinutes(int.Parse(_configuration["JWtConfig:expires"])),
                notBefore: DateTime.Now,
                claims: claims,
                signingCredentials: credentials
            );
            var jwtToken = new JwtSecurityTokenHandler().WriteToken(token);

            return Ok(jwtToken);

        }
    }
}
