using ErrorOr;
using Hotel.App.Common.Errors;
using Hotel.App.Common.Interfaces;
using Hotel.App.Room.Queries.GetRoomDetails;
using Hotel.App.Room.Vm;
using MediatR;

namespace Hotel.App.Room.Queries.GetAllRooms;
public class GetAllRoomsQueryHandler
    : IRequestHandler<GetAllRoomsQuery, ErrorOr<RoomsVm>>

{
    private readonly IUnitOfWork _unitOfWork;

    public GetAllRoomsQueryHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<ErrorOr<RoomsVm>> Handle(
        GetAllRoomsQuery request, 
        CancellationToken cancellationToken)
    {
        var rooms = await _unitOfWork.Rooms.FindAllRooms();
        if(rooms is null)
        {
            return Errors.Room.NotFound;
        }

        var roomsModel = rooms.Select(room => new RoomDetailsVm(
            room.Id.ToString(),
            new CategoryRoomVm(
                room?.Category?.Id.ToString(),
                room?.Category?.Category,
                room?.Category?.QuantityPersons,
                room?.Category?.QuantityRooms,
                room?.Category?.Description,
                room?.Category?.Price
                ),
            new RoomConditionVm(
                room?.Condition?.Id.ToString(),
                new EmployeeVm(
                    room?.Condition?.Employee?.Id.ToString(),
                    room?.Condition?.Employee?.LastName,
                    room?.Condition?.Employee?.FirstName,
                    room?.Condition?.Employee?.Patronymic,
                    room?.Condition?.Employee?.Birthday,
                    room?.Condition?.Employee?.Education,
                    new JobtitleVm(
                        room?.Condition?.Employee?.JobTitle?.Id.ToString(),
                        room?.Condition?.Employee?.JobTitle?.JobTitle),
                    room?.Condition?.Employee?.Salary
                    ),
                new BookingVm(
                    room?.Condition?.Booking?.Id.ToString(),
                    room?.Condition?.Booking?.GetStatus,
                    new List<ClientVm>(room.Condition.Booking.Clients.Select(client => new ClientVm(
                        client.Id.ToString(),
                        client.LastName,
                        client.FirstName,
                        client.Patronymic,
                        client.Birthday,
                        client.Sex)
                        )
                        )
                    ),
                    room.Condition.CheckIn,
                    room.Condition.Departure,
                    room.Condition.TotalPrice),
            room.Thumbnail
            )).ToList();

        var result = new RoomsVm(roomsModel);

        return result;
    }
}
