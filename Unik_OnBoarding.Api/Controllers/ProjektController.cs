using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Unik_OnBoarding.Application.DTO.Projekt;
using Unik_OnBoarding.Application.Features.Stamdata.Command.CreateProjekt;
using Unik_OnBoarding.Application.Features.Stamdata.Command.DeleteProjekt;
using Unik_OnBoarding.Application.Features.Stamdata.Command.UpdateProjekt;
using Unik_OnBoarding.Application.Features.Stamdata.Queries.GetProjektDetail;
using Unik_OnBoarding.Application.Features.Stamdata.Queries.GetProjektList;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Unik_OnBoarding.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProjektController : ControllerBase
{
    private IMapper _mapper;

    private IMediator _mediator;

    public ProjektController(IMediator mediator)
    {
        _mediator = mediator;
    }

    protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();

    // Get all
    [HttpGet(Name = "GetAll")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetAll()
    {
        try
        {
            return Ok(await _mediator.Send(new GetProjektListQuery()));
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }


    // GET api/<ProjektController>/5
    [HttpGet("{id:Guid}", Name = "Get Projekt by ID")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<ProjektDto>> GetProjektByID(Guid id)
    {
        try
        {
            return Ok(await _mediator.Send(new GetProjektDetailQuery { ProjektId = id }));
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
    }

    // POST api/<ProjektController>
    [HttpPost(Name = "Add new Project")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Guid>> AddNewProjekt([FromBody] CreateProjektCommand createProjektCommand)
    {
        Guid newProejktID = await _mediator.Send(createProjektCommand);
        return Ok(newProejktID);
    }

    // PUT api/<ProjektController>/5
    [HttpPut(Name = "Update Project")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult> UpdateProjekt([FromBody] UpdateProjektCommand updateProjektCommand)
    {
        await _mediator.Send(updateProjektCommand);
        return NoContent();
    }

    // DELETE api/<ProjektController>/5
    [HttpDelete("{id:Guid}",Name = "Delete Project")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult> DeleteProjekt(Guid id)
    {
        var deleteProjekt = new DeleteProjektCommand() { ProjektId = id };
        await _mediator.Send(deleteProjekt);
        return NoContent();
    }
}