using MediatR;
using Microsoft.AspNetCore.Mvc;
using Unik_OnBoarding.Application.DTO.Projekt;
using Unik_OnBoarding.Application.Features.Stamdata.Queries.GetProjektDetail;
using Unik_OnBoarding.Application.Features.Stamdata.Queries.GetProjektList;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Unik_OnBoarding.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjektController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProjektController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet("all", Name = "GetAllProjekt")]
        public async Task<ActionResult<IEnumerable<ProjektDto>>> GetAllProjekt()
        {
            var request = new GetProjektListQuery();
            var ListOfProjekt = await _mediator.Send(request);
            return Ok(ListOfProjekt);
        }

        // GET api/<ProjektController>/5
        [HttpGet("{id:Guid}")]
        public async Task<ActionResult<ProjektDto>> GetProjektByID(Guid id)
        {
            var projekt = new GetProjektDetailQuery() { ProjektId = id };
            return Ok(await _mediator.Send(projekt));
        }

        // POST api/<ProjektController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ProjektController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProjektController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
