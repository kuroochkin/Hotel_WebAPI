using Hotel.Domain.Room;

namespace Hotel.App.Common.Interfaces;

public interface IRoomRepository : IGenericRepository<RoomEntity>
{
	Task<RoomEntity?> FindRoomWithConditionAndCategory(Guid id);
}
