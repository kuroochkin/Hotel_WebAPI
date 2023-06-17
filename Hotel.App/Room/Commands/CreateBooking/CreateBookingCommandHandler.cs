using ErrorOr;
using Hotel.App.Common.Errors;
using Hotel.App.Common.Interfaces;
using Hotel.Domain.Booking;
using Hotel.Domain.Room;
using MediatR;
using static Hotel.Domain.Booking.BookingEntity;

namespace Hotel.App.Room.Commands.CreateBooking;

public class CreateBookingCommandHandler
	: IRequestHandler<CreateBookingCommand, ErrorOr<bool>>
{
	private readonly IUnitOfWork _unitOfWork;

	public CreateBookingCommandHandler(IUnitOfWork unitOfWork)
	{
		_unitOfWork = unitOfWork;
	}

	public async Task<ErrorOr<bool>> Handle(
		CreateBookingCommand request, 
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

		var booking = new BookingEntity(BookingStatus.Free);

		var roomCondition = new RoomConditionEntity(booking, request.TotalPrice);

		room.Condition = roomCondition;

		if (await _unitOfWork.Bookings.Add(booking) && await _unitOfWork.RoomConditions.Add(roomCondition))
		{
			return await _unitOfWork.CompleteAsync();
		}

		return false;
	}
}
