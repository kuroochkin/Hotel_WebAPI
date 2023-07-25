using Hotel.Domain.Room;

namespace Hotel.App.Common.Interfaces;

public interface IRoomRepository : IGenericRepository<RoomEntity>
{
    Task<List<RoomEntity>?> FindAllRooms();

    Task<RoomEntity?> FindRoomWithConditionAndCategory(Guid id, CancellationToken cancellationToken = default);

	Task<List<RoomEntity>?> FindFreeRooms();

	Task<List<RoomEntity>?> FindRoomsByCountSuite(int quantitySuite);

	Task<List<RoomEntity>?> FindRoomsByCountPersons(int quantityPersons);
}
