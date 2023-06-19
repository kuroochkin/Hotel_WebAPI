using ErrorOr;
using Hotel.App.Room.Vm;
using MediatR;

namespace Hotel.App.Room.Queries.GetAllRooms;
public record GetAllRoomsQuery() : IRequest<ErrorOr<RoomsVm>>
{

}
