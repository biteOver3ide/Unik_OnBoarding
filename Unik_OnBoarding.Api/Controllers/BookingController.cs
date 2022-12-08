using MediatR;
using Microsoft.AspNetCore.Mvc;
using Unik_OnBoarding.Application.Features.Booking.Command.CreateBooking;
using Unik_OnBoarding.Application.Features.Booking.Command.DeleteBooking;
using Unik_OnBoarding.Application.Features.Booking.Command.UpdateBooking;
using Unik_OnBoarding.Application.Features.Booking.Queries.GetBookingDetail;
using Unik_OnBoarding.Application.Features.Booking.Queries.GetBookingList;
using Unik_OnBoarding.Application.Implementation.Booking.dto;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Unik_OnBoarding.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BookingController : ControllerBase
{
    private readonly IMediator _mediator;

    public BookingController(IMediator mediator)
    {
        _mediator = mediator;
    }

    // GET: api/<BookingController>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetAllBookinger()
    {
        try
        {
            return Ok(await _mediator.Send(new GetBookingListQuery()));
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    // GET api/<BookingController>/5
    [HttpGet("{id:Guid}", Name = "Get Booking by ID")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<BookingDto>> GetBookingByID(Guid id)
    {
        try
        {
            return Ok(await _mediator.Send(new GetBookingDetailQuery { BookingId = id }));
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
    }

    // POST api/<BookingController>
    [HttpPost(Name = "Add new Booking")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Guid>> AddNewBooking([FromBody] CreateBookingCommand createBookingCommand)
    {
        try
        {
            var newBookingID = await _mediator.Send(createBookingCommand);
            return Ok(newBookingID);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
    }

    // PUT api/<BookingController>/5
    [HttpPut(Name = "Update Booking")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult> UpdateBooking([FromBody] UpdateBookingCommand updateBookingCommand)
    {
        try
        {
            await _mediator.Send(updateBookingCommand);
            return NoContent();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
    }

    // DELETE api/<BookingController>/5
    [HttpDelete("{id:Guid}", Name = "Delete Booking")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult> DeleteBooking(Guid id)
    {
        try
        {
            var deleteBooking = new DeleteBookingCommand { BookingId = id };
            await _mediator.Send(deleteBooking);
            return NoContent();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
    }
}