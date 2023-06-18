using Hotel.App.Room.Commands.CreateBooking;
using Hotel.App.Room.Queries.GetRoomDetails;
using Hotel.Contracts.Room.Get;
using Hotel.Contracts.Room.Requests;
using MapsterMapper;
using Mapster;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Hotel.App.Room.Queries.GetFreeRooms;

namespace Hotel.API.Controllers.Room;

[ApiController]
[Route("api/room")]
public class RoomController : ControllerBase
{
	private readonly ISender _mediator;
	private readonly IMapper _mapper;

	public RoomController(ISender mediator, IMapper mapper)
	{
		_mediator = mediator;
		_mapper = mapper;
	}

	[HttpGet("{roomId}")]
	public async Task<IActionResult> GetDetailsOrder(string roomId)
	{
		var query = new GetRoomDetailsQuery(roomId);

		var roomResult = await _mediator.Send(query);

		return roomResult.Match(
			room => Ok(_mapper.Map<GetRoomDetailsResponse>(room)),
			errors => Problem("Ошибка")
		);
	}

	[HttpGet("freeRooms")]
	public async Task<IActionResult> GetFreeRoomsr()
	{
		var query = new GetFreeRoomsQuery();

		var roomsResult = await _mediator.Send(query);

		return roomsResult.Match(
			rooms => Ok(_mapper.Map<GetRoomsResponse>(rooms)),
			errors => Problem("Ошибка")
		);
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
