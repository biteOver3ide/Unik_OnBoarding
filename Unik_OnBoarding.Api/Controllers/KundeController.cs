using MediatR;
using Microsoft.AspNetCore.Mvc;
using Unik_OnBoarding.Application.DTO.Kunde;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Unik_OnBoarding.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KundeController : ControllerBase
    {
        private readonly IMediator _mediator;

        public KundeController(IMediator mediator)
        {
            _mediator = mediator;
        }
        // GET: api/<KundeController>
        [HttpGet]
        //public async Task<ActionResult<List<KundeDto>>> GetAllKunde()
        //{
        //    var KundeList = await _mediator.Send()
        //    return ;
        //}

        // GET api/<KundeController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<KundeController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<KundeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<KundeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
