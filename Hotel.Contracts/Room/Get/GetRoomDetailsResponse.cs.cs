using Hotel.Contracts.CategoryRoom.Get;
using Hotel.Contracts.RoomCondition.Get;

namespace Hotel.Contracts.Room.Get;

public record GetRoomDetailsResponse(
string Id,
CategoryRoomResponse Category,
RoomConditionResponse Condition,
string Thumbnail);

