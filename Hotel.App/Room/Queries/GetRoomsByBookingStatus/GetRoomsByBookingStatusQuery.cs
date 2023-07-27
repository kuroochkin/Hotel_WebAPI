using Hotel.App.Room.Vm;
using ErrorOr;
using Hotel.Domain.Booking;
using MediatR;

namespace Hotel.App.Room.Queries.GetRoomsByBookingStatus;

public record GetRoomsByBookingStatusQuery(string bookingStatus) : IRequest<ErrorOr<RoomsVm>>
{
}
