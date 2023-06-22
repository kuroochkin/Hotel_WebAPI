namespace Hotel.App.Room.Vm;

public record CategoryRoomVm(
	string? Id,
	string? Category,
	int? QuantityPersons,
	int? QuantityRooms,
	string? Description,
	decimal? Price
	);

