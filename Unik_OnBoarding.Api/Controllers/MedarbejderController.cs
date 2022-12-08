using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;
using Unik_OnBoarding.Application.Features.Medarbejder.Command.CreateMedarbejder;
using Unik_OnBoarding.Application.Features.Medarbejder.Command.DeleteMedarbejder;
using Unik_OnBoarding.Application.Features.Medarbejder.Queries.GetMedarbejderDetail;
using Unik_OnBoarding.Application.Features.Medarbejder.Queries.GetMedarbejderList;
using Unik_OnBoarding.Application.Implementation.Kunde.dto;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Unik_OnBoarding.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MedarbejderController : ControllerBase
{
    private readonly IMediator _mediator;

    public MedarbejderController(IMediator mediator)
    {
        _mediator = mediator;
    }

    // GET: api/<MedarbejderController>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetAllMedarbejder()
    {
        try
        {
            return Ok(await _mediator.Send(new GetMedarbejderListQuery()));
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    // GET api/<MedarbejderController>/5
    [HttpGet("{id:Guid}", Name = "Get Medarbejder by ID")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<KundeDto>> GetMedarbejderByID(Guid id)
    {
        try
        {
            return Ok(await _mediator.Send(new GetMedarbejderDetailQuery { MedarbejderId = id }));
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
    }

    // POST api/<MedarbejderController>
    [HttpPost]
    [Consumes(MediaTypeNames.Application.Json)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Guid>> Post(
        [FromBody] CreateMedarbejderCommand createMedarbejderCommand)
    {
        try
        {
            var newMedarbejderID = await _mediator.Send(createMedarbejderCommand);
            return Ok(newMedarbejderID);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
    }

    // PUT api/<MedarbejderController>/5
    [HttpPut(Name = "EDIT")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult> UpdateMedarbejder([FromBody] CreateMedarbejderCommand createMedarbejderCommand)
    {
        try
        {
            await _mediator.Send(createMedarbejderCommand);
            return NoContent();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
    }

    // DELETE api/<MedarbejderController>/5
    [HttpDelete("{id:Guid}", Name = "Delete Medarbejder")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult> DeleteMedarbejder(Guid id)
    {
        try
        {
            var deleteMedarbejder = new DeleteMedarbejderCommand { MedarbejderId = id };
            await _mediator.Send(deleteMedarbejder);
            return NoContent();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
    }
}