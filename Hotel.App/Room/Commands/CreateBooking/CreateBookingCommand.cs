using ErrorOr;
using MediatR;

namespace Hotel.App.Room.Commands.CreateBooking;

public record CreateBookingCommand(
	string RoomId,
	decimal TotalPrice) : IRequest<ErrorOr<bool>>;

