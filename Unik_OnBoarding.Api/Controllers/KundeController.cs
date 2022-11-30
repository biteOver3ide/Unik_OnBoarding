using MediatR;
using Microsoft.AspNetCore.Mvc;
using Unik_OnBoarding.Application.DTO.Kunde;
using Unik_OnBoarding.Application.Features.Stamdata.Kunde.Command.CreateKunde;
using Unik_OnBoarding.Application.Features.Stamdata.Kunde.Command.DeleteKunde;
using Unik_OnBoarding.Application.Features.Stamdata.Kunde.Command.UpdateKunde;
using Unik_OnBoarding.Application.Features.Stamdata.Kunde.Queries.GetKundeDetail;
using Unik_OnBoarding.Application.Features.Stamdata.Kunde.Queries.GetKundeList;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Unik_OnBoarding.Api.Controllers;

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
    [HttpGet(Name = "GetAll")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetAllKunder()
    {
        try
        {
            return Ok(await _mediator.Send(new GetKundeListQuery()));
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    // GET api/<KundeController>/5
    [HttpGet("{id:Guid}", Name = "Get Kunde by ID")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<KundeDto>> GetKundeByID(Guid id)
    {
        try
        {
            return Ok(await _mediator.Send(new GetKundeDetailQuery { Kid = id }));
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
    }

    // POST api/<KundeController>
    [HttpPost(Name = "Add new Kunde")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Guid>> AddNewKunde([FromBody] CreateKunderCommand createKunderCommand)
    {
        try
        {
            var newKundeID = await _mediator.Send(createKunderCommand);
            return Ok(newKundeID);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
    }

    // PUT api/<KundeController>/5
    [HttpPut(Name = "Update Kunde")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult> UpdateKunde([FromBody] UpdateKunderCommand updateKunderCommand)
    {
        try
        {
            await _mediator.Send(updateKunderCommand);
            return NoContent();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
    }

    // DELETE api/<KundeController>/5
    [HttpDelete("{id:Guid}", Name = "Delete Kunde")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult> DeleteKunde(Guid id)
    {
        try
        {
            var deleteKunde = new DeleteKunderCommand { Kid = id };
            await _mediator.Send(deleteKunde);
            return NoContent();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
    }
}