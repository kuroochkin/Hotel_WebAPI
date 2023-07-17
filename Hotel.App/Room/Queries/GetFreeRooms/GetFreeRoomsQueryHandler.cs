using AutoMapper;
using ErrorOr;
using Hotel.App.Common.Errors;
using Hotel.App.Common.Interfaces;
using Hotel.App.Room.Vm;
using MediatR;

namespace Hotel.App.Room.Queries.GetFreeRooms;

public class GetFreeRoomsQueryHandler
	: IRequestHandler<GetFreeRoomsQuery, ErrorOr<RoomsVm>>
{
	private readonly IUnitOfWork _unitOfWork;
	private readonly IMapper _mapper;

	public GetFreeRoomsQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
	{
		_unitOfWork = unitOfWork;
		_mapper = mapper;
	}

	public async Task<ErrorOr<RoomsVm>> Handle(
		GetFreeRoomsQuery request, 
		CancellationToken cancellationToken)
	{
		var rooms = await _unitOfWork.Rooms.FindFreeRooms();
		if(rooms is null)
		{
			return Errors.Room.NotFound;
		}

		var result = _mapper.Map<RoomsVm>(rooms);

		return result;

		//var roomsModel = rooms.Select(room => new RoomDetailsVm(
		//	room.Id.ToString(),
		//	new CategoryRoomVm(
		//		room?.Category?.Id.ToString(),
		//		room?.Category?.Category,
		//		room?.Category?.QuantityPersons,
		//		room?.Category?.QuantityRooms,
		//		room?.Category?.Description,
		//		room?.Category?.Price
		//		),
		//	new RoomConditionVm(
		//		room?.Condition?.Id.ToString(),
		//		new EmployeeVm(
		//			room?.Condition?.Employee?.Id.ToString(),
		//			room?.Condition?.Employee?.LastName,
		//			room?.Condition?.Employee?.FirstName,
		//			room?.Condition?.Employee?.Patronymic,
		//			room?.Condition?.Employee?.Birthday,
		//			room?.Condition?.Employee?.Education,
		//			new JobtitleVm(
		//				room?.Condition?.Employee?.JobTitle?.Id.ToString(),
		//				room?.Condition?.Employee?.JobTitle?.JobTitle),
		//			room?.Condition?.Employee?.Salary
		//			),
		//		new BookingVm(
		//			room?.Condition?.Booking?.Id.ToString(),
		//			room?.Condition?.Booking?.GetStatus,
		//			new List<ClientVm>(room.Condition.Booking.Clients.Select(client => new ClientVm(
		//				client.Id.ToString(),
		//				client.LastName,
		//				client.FirstName,
		//				client.Patronymic,
		//				client.Birthday,
		//				client.Sex)
		//				)
		//				)
		//			),
		//			room.Condition.CheckIn,
		//			room.Condition.Departure,
		//			room.Condition.TotalPrice),
		//	room.Thumbnail))
		//.ToList();

		//var result = new RoomsVm(roomsModel);

		//return result;
	}
}
