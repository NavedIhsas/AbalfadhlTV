using AbalfadhlTV.Application.Dtos.Beqa;
using AbalfadhlTV.Application.Services.Beqa;
using AbalfadhlTV.Common.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace AbalfadhlTV.Api.Endpoint.Controllers.V1.Beqa
{
    [ApiVersion("1")]
    
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class BeqaController : ControllerBase
    {
        private readonly IBeqaService _services;

        public BeqaController(IBeqaService services)
        {
            _services = services;
        }



        [HttpGet]
       // [Route("{apiKey}&{page}&{pageSize}")]
        public IActionResult Get(string apiKey= "2A2BB29A-C828-4E00-B47E-B7FD1A9FFB01", int page = 1, int pageSize = 30)
        {
            var result = _services.GetList(page, pageSize).Data.Select(x => new GetBeqaList()
            {
                Id = x.Id,
                Name = x.Name,
                Type = x.Type,
                Country = x.Country,
                City = x.City,
                Child = x.Child,
                Address = x.Address,
                Links = new List<Link>()
                {
                    new Link()
                    {
                        Href = Url.Action(nameof(Get), "Beqa", new { x.Id }, Request.Scheme),
                        Method = "Get",
                        Ref = "Self"
                    },
                    new Link()
                    {
                        Href = Url.Action(nameof(Put), "Beqa", Request.Scheme),
                        Method = "Put",
                        Ref = "Update"
                    },
                    new Link()
                    {
                        Href = Url.Action(nameof(Delete), "Beqa", new { x.Id }, Request.Scheme),
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
            return Ok(result);
        }


        [HttpPost]
        public IActionResult Post([FromBody] AddBeqa command)
        {
            var result = _services.Add(command);
            var url = Url.Action(nameof(Get), "Beqa", new { Id = result.Data.Id }, Request.Scheme);
            return Created(url, result.Message);
        }

        [HttpPut()]
        public IActionResult Put([FromBody] EditBeqa command)
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
