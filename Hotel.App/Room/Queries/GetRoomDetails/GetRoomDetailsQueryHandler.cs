﻿using ErrorOr;
using Hotel.App.Common.Errors;
using Hotel.App.Common.Interfaces;
using Hotel.App.Room.Vm;
using MediatR;

namespace Hotel.App.Room.Queries.GetRoomDetails;

public class GetRoomDetailsQueryHandler
	: IRequestHandler<GetRoomDetailsQuery, ErrorOr<RoomDetailsVm>>
{
	private readonly IUnitOfWork _unitOfWork;

	public GetRoomDetailsQueryHandler(IUnitOfWork unitOfWork)
	{
		_unitOfWork = unitOfWork;
	}

	public async Task<ErrorOr<RoomDetailsVm>> Handle(
		GetRoomDetailsQuery request, 
		CancellationToken cancellationToken)
	{
		if (!Guid.TryParse(request.RoomId, out var roomId))
		{
			return Errors.Room.InvalidId;
		}

		var room = await _unitOfWork.Rooms.FindRoomWithConditionAndCategory(roomId);
		if(room is null)
		{
			return Errors.Room.NotFound;
		}

		var roomInfo = new RoomDetailsVm(
			room.Id.ToString(),
			new CategoryRoomVm(
				room.Category.Id.ToString(),
				room.Category.Category,
				room.Category.QuantityPersons,
				room.Category.QuantityRooms,
				room.Category.Description,
				room.Category.Price
				),
			new RoomConditionVm(
				room.Condition.Id.ToString(),
				new EmployeeVm(
					room.Condition.Employee.Id.ToString(),
					room.Condition.Employee.LastName,
					room.Condition.Employee.FirstName,
					room.Condition.Employee.Patronymic,
					room.Condition.Employee.Birthday,
					room.Condition.Employee.Education,
					new JobtitleVm(
						room.Condition.Employee.JobTitle.Id.ToString(),
						room.Condition.Employee.JobTitle.JobTitle),
					room.Condition.Employee.Salary
					),
				new BookingVm(
					room.Condition.Booking.Id.ToString(),
					room.Condition.Booking.GetStatus),
				room.Condition.CheckIn,
				room.Condition.Departure,
				room.Condition.TotalPrice),
			room.Thumbnail
			);

		return roomInfo;
	}
}