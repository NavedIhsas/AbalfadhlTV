using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AbalfadhlTV.Api.Endpoint.Controllers.V1.User
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserTokenController : ControllerBase
    {
        private readonly UserManager<IdentityUserToken<long>> _userManager;

        public UserTokenController(UserManager<IdentityUserToken<long>> userManager)
        {
            _userManager = userManager;
        }

      
    }
}
