using AbalfadhlTV.Application.Interfaces.Imamzadeha;
using AbalfadhlTV.Common.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace AbalfadhlTV.Api.Endpoint.Controllers.V1
{
    [ApiVersion("1")]
    [Route("api/[controller]")]
    [ApiController]
   
    public class ImamzadehaController : ControllerBase
    {
        private readonly ICountryImamzadehServices _services;

        public ImamzadehaController(ICountryImamzadehServices services)
        {
            _services = services;
        }


        [HttpGet]
        public IActionResult Get(int page = 1, int pageSize = 10)
        {
            var result = _services.GetList(page, pageSize).Data.Select(x => new CountryImamzadehListDto()
            {
                Id = x.Id,
                Name = x.Name,
                Links = new List<Link>()
                {
                    new Link()
                    {
                        Href = Url.Action(nameof(Get), "Imamzadeha", new { x.Id }, Request.Scheme),
                        Method = "Get",
                        Ref = "Self"
                    },
                    new Link()
                    {
                        Href = Url.Action(nameof(Put), "Imamzadeha", Request.Scheme),
                        Method = "Put",
                        Ref = "Update"
                    },
                    new Link()
                    {
                        Href = Url.Action(nameof(Delete), "Imamzadeha", new { x.Id }, Request.Scheme),
                        Method = "Delete",
                        Ref = "Delete"
                    },
                }

            });
            return Ok(result);
        }


        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var result = _services.FindById(id);
            var res = new CountryImamzadehDto() { Id = result.Data.Id, Name = result.Data.Name };

            return Ok(res);
        }


        [HttpPost]
        public IActionResult Post([FromBody] string name)
        {
            var command = new CountryImamzadehDto() { Name = name };
            var result = _services.Add(command);
            var url = Url.Action(nameof(Get), "Imamzadeha", new { Id = result.Data.Id }, Request.Scheme);
            return Created(url, result.Message);
        }

        [HttpPut()]
        public IActionResult Put([FromBody] CountryImamzadehDto command)
        {
            var result = _services.Edit(command);
            return Ok(result.Message);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            var result = _services.Remove(id);
            return Ok(result.Message);
        }
    }
}
