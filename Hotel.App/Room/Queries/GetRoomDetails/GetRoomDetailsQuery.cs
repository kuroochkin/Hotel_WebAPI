using ErrorOr;
using Hotel.App.Room.Vm;
using MediatR;

namespace Hotel.App.Room.Queries.GetRoomDetails;

public record GetRoomDetailsQuery(string RoomId) : IRequest<ErrorOr<RoomDetailsVm>>
{
}
