using static Hotel.Domain.Booking.BookingEntity;

namespace Hotel.App.Room.Vm;

public record BookingVm(
	string? Id,
	BookingStatus? Status,
	List<ClientVm> Clients
	);