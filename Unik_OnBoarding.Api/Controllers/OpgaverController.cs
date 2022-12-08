using MediatR;
using Microsoft.AspNetCore.Mvc;
using Unik_OnBoarding.Application.Features.Opgaver.Command.CreateOpgaver;
using Unik_OnBoarding.Application.Features.Opgaver.Command.DeleteOpgaver;
using Unik_OnBoarding.Application.Features.Opgaver.Command.UpdateOpgaver;
using Unik_OnBoarding.Application.Features.Opgaver.Queries.GetOpgaverDetail;
using Unik_OnBoarding.Application.Features.Opgaver.Queries.GetOpgaverList;
using Unik_OnBoarding.Application.Implementation.Opgaver.dto;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Unik_OnBoarding.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class OpgaverController : ControllerBase
{
    private readonly IMediator _mediator;

    public OpgaverController(IMediator mediator)
    {
        _mediator = mediator;
    }

    // GET: api/<OpgaverController>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetAllOpgaver()
    {
        try
        {
            return Ok(await _mediator.Send(new GetOpgaverListQuery()));
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    // GET api/<OpgaverController>/5
    [HttpGet("{id:Guid}", Name = "Get Opgave by ID")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<OpgaverDto>> GetOpgaveByID(Guid id)
    {
        try
        {
            return Ok(await _mediator.Send(new GetOpgaverDetailQuery { OpgaverId = id }));
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
    }

    // POST api/<OpgaverController>
    [HttpPost(Name = "Add new Opgave")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Guid>> AddNewOpgave([FromBody] CreateOpgaverCommand createOpgaverCommand)
    {
        try
        {
            var newOpgaveID = await _mediator.Send(createOpgaverCommand);
            return Ok(newOpgaveID);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
    }

    // PUT api/<OpgaverController>/5
    [HttpPut(Name = "Update Opgave")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult> UpdateOpgave([FromBody] UpdateOpgaverCommand updateOpgaverCommand)
    {
        try
        {
            await _mediator.Send(updateOpgaverCommand);
            return NoContent();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
    }

    // DELETE api/<OpgaverController>/5
    [HttpDelete("{id:Guid}", Name = "Delete Opgave")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult> DeleteOpgave(Guid id)
    {
        try
        {
            var deleteOpgave = new DeleteOpgaverCommand { OpgaveId = id };
            await _mediator.Send(deleteOpgave);
            return NoContent();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
    }
}