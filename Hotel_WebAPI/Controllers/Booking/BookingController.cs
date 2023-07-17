using AutoMapper;
using Hotel.App.Room.Commands.CreateBooking;
using Hotel.Contracts.Room.Requests;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Hotel.API.Controllers.Booking;

[ApiController]
[Route("api/booking")]
public class BookingController : ControllerBase
{
	private readonly ISender _mediator;
	private readonly IMapper _mapper;

	public BookingController(ISender mediator, IMapper mapper)
	{
		_mediator = mediator;
		_mapper = mapper;
	}

	[HttpPost("create")]
	public async Task<IActionResult> CreateBooking(CreateBookingRequest request)
	{
		var command = _mapper.Map<CreateBookingCommand>(request);

		var result = await _mediator.Send(command);

		return result.Match(
			orderResult => Ok(result.Value),
			errors => Problem("Ошибка")
			);
	}
}
