using AbalfadhlTV.Application.Dtos.Beqa;
using AbalfadhlTV.Application.Services.Beqa;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AbalfadhlTV.Api.Endpoint.Controllers.V1.Beqa
{
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/Beqa/Collection")]
    [ApiController]
    public class BeqaCollectionController : ControllerBase
    {
        private readonly IBeqaService _services;

        public BeqaCollectionController(IBeqaService services)
        {
            _services = services;
        }

        [HttpPost]
        public IActionResult Post([FromBody] List<AddBeqa> command)
        {
            var result = _services.AddCollection(command);
            return Ok(result.IsSuccess);
        }

        [HttpDelete]
        public IActionResult Delete(List<long> id)
        {
            var result = _services.RemoveCollection(id);
            return Ok(result.IsSuccess);
        }
    }
}
