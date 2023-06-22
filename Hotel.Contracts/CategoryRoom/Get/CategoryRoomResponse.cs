namespace Hotel.Contracts.CategoryRoom.Get;

public record CategoryRoomResponse(
	string Id,
	string Category,
	int QuantityPersons,
	int QuantityRooms,
	string Description,
	decimal Price
	);
