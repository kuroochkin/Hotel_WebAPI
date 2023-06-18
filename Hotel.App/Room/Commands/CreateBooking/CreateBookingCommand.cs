using ErrorOr;
using Hotel.Contracts.Room.Requests;
using MediatR;

namespace Hotel.App.Room.Commands.CreateBooking;

public record CreateBookingCommand(
	string RoomId,
	decimal TotalPrice,
	List<GetClientsRequest> Clients) : IRequest<ErrorOr<bool>>;

