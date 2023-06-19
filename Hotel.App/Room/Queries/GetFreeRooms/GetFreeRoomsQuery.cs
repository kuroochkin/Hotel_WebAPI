using ErrorOr;
using Hotel.App.Room.Vm;
using MediatR;

namespace Hotel.App.Room.Queries.GetFreeRooms;

public record GetFreeRoomsQuery() : IRequest<ErrorOr<RoomsVm>>
{
}

