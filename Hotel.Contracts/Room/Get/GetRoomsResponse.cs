namespace Hotel.Contracts.Room.Get;

public record GetRoomsResponse(
	List<GetRoomDetailsResponse> Rooms);
