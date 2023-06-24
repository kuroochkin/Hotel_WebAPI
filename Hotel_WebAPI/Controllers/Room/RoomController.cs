using Hotel.App.Room.Commands.CreateBooking;
using Hotel.App.Room.Queries.GetRoomDetails;
using Hotel.Contracts.Room.Get;
using Hotel.Contracts.Room.Requests;
using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Hotel.App.Room.Queries.GetFreeRooms;
using Hotel.App.Room.Queries.GetAllRooms;
using Hotel.App.Room.Queries.GetRoomsByCountSuite;
using Hotel.App.Room.Queries.GetRoomsByCountPersons;

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

	[HttpGet("quantitySuite/{count}")]
	public async Task<IActionResult> GetRoomsByCountSuite(int count)
	{
		var query = new GetRoomsByCountSuiteQuery(count);

		var roomResult = await _mediator.Send(query);

		return roomResult.Match(
			rooms => Ok(_mapper.Map<GetRoomsResponse>(rooms)),
			errors => Problem("Ошибка")
		);
	}

	[HttpGet("quantityPersons/{count}")]
	public async Task<IActionResult> GetRoomsByCountPersons(int count)
	{
		var query = new GetRoomsByCountPersonsQuery(count);

		var roomResult = await _mediator.Send(query);

		return roomResult.Match(
			rooms => Ok(_mapper.Map<GetRoomsResponse>(rooms)),
			errors => Problem("Ошибка")
		);
	}

	[HttpGet("allRooms")]
	public async Task<IActionResult> GetAllRooms()
	{
		var query = new GetAllRoomsQuery();

		var roomsResult = await _mediator.Send(query);

        return roomsResult.Match(
            rooms => Ok(_mapper.Map<GetRoomsResponse>(rooms)),
            errors => Problem("Ошибка")
        );
    }

	[HttpGet("freeRooms")]
	public async Task<IActionResult> GetFreeRooms()
	{
		var query = new GetFreeRoomsQuery();

		var roomsResult = await _mediator.Send(query);

		return roomsResult.Match(
			rooms => Ok(_mapper.Map<GetRoomsResponse>(rooms)),
			errors => Problem("Ошибка")
		);
	}
}
