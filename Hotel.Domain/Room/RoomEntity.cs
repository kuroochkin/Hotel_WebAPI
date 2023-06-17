
using Hotel.Domain.CategoryRoom;

namespace Hotel.Domain.Room;

public class RoomEntity
{
	public Guid Id { get; set; }

	public CategoryRoomEntity? Category { get; set; }

	public RoomConditionEntity? Condition { get; set; }

	public string? Thumbnail { get; set; }
}
