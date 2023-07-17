using ErrorOr;
using Hotel.App.Room.Vm;
using MediatR;

namespace Hotel.App.Room.Queries.GetRoomsByCountPersons;

public record GetRoomsByCountPersonsQuery(int QuantityPersons) : IRequest<ErrorOr<RoomsVm>>
{
}
