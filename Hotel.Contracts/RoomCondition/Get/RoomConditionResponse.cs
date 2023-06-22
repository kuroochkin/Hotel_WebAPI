using Hotel.Contracts.Booking.Get;
using Hotel.Contracts.Employee.Get;

namespace Hotel.Contracts.RoomCondition.Get;

public record RoomConditionResponse(
	string Id,
	EmployeeResponse? Employee,
	BookingResponse Booking,
	DateTime CheckIn,
	DateTime Departure,
	decimal TotalPrice
	);

