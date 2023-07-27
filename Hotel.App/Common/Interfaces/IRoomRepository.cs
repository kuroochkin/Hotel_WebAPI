using Hotel.Domain.Room;
using static Hotel.Domain.Booking.BookingEntity;

namespace Hotel.App.Common.Interfaces;

public interface IRoomRepository : IGenericRepository<RoomEntity>
{
    Task<List<RoomEntity>?> FindAllRooms();

    Task<RoomEntity?> FindRoomWithConditionAndCategory(Guid id, CancellationToken cancellationToken = default);

    Task<List<RoomEntity>?> FindRoomsByCountSuite(int quantitySuite);

	Task<List<RoomEntity>?> FindRoomsByCountPersons(int quantityPersons);

	Task<List<RoomEntity>?> FindRoomsByBookingStatus(BookingStatus bookingStatus);
}
