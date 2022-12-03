using MediatR;
using Microsoft.AspNetCore.Mvc;
using Unik_OnBoarding.Application.Features.Stamdata.Kompetence.Command.CreateKompetence;
using Unik_OnBoarding.Application.Features.Stamdata.Kompetence.Command.DeleteKompetence;
using Unik_OnBoarding.Application.Features.Stamdata.Kompetence.Command.UpdateKompetence;
using Unik_OnBoarding.Application.Features.Stamdata.Kompetence.Queries.GetKompetenceDetail;
using Unik_OnBoarding.Application.Features.Stamdata.Kompetence.Queries.GetKompetenceList;
using Unik_OnBoarding.Application.Implementation.Kompetencer.dto;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Unik_OnBoarding.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class KompetenceController : ControllerBase
{
    private readonly IMediator _mediator;

    public KompetenceController(IMediator mediator)
    {
        _mediator = mediator;
    }

    // GET: api/<KompetenceController>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetAllKompetence()
    {
        try
        {
            return Ok(await _mediator.Send(new GetKompetenceListQuery()));
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    // GET api/<KompetenceController>/5
    [HttpGet("{id:Guid}", Name = "Get Kompetence by ID")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<KompetenceDto>> GetKompetenceByID(Guid id)
    {
        try
        {
            return Ok(await _mediator.Send(new GetKompetenceDetailQuery { KompetencerId = id }));
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
    }

    // POST api/<KompetenceController>
    [HttpPost(Name = "Add new Kompetence")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Guid>> AddNewKompetence([FromBody] CreateKompetenceCommand createKompetenceCommand)
    {
        try
        {
            var newKompetenceID = await _mediator.Send(createKompetenceCommand);
            return Ok(newKompetenceID);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
    }

    // PUT api/<KompetenceController>/5
    [HttpPut(Name = "Update Kompetence")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult> UpdateKompetence([FromBody] UpdateKompetenceCommand updateKompetenceCommand)
    {
        try
        {
            await _mediator.Send(updateKompetenceCommand);
            return NoContent();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
    }

    // DELETE api/<KompetenceController>/5
    [HttpDelete("{id:Guid}", Name = "Delete Kompetence")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult> DeleteKompetence(Guid id)
    {
        try
        {
            var deleteKompetence = new DeleteKompetenceCommand { KompetenceId = id };
            await _mediator.Send(deleteKompetence);
            return NoContent();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
    }
}