namespace Hotel.App.Room.Vm;

public record RoomConditionVm(
	string? Id,
	EmployeeVm? Employee,
	BookingVm? Booking,
	DateTime CheckIn,
	DateTime Departure,
	decimal TotalPrice
	);
