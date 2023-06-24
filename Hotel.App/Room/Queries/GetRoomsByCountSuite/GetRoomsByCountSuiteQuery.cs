using ErrorOr;
using Hotel.App.Room.Vm;
using MediatR;

namespace Hotel.App.Room.Queries.GetRoomsByCountSuite;

public record GetRoomsByCountSuiteQuery(int QuantitySuite) : IRequest<ErrorOr<RoomsVm>>
{
}