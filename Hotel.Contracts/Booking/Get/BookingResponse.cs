using Hotel.Contracts.Client.Get;
using static Hotel.Domain.Booking.BookingEntity;

namespace Hotel.Contracts.Booking.Get;

public record BookingResponse(
	string Id,
	BookingStatus Status,
	List<ClientResponse> Clients
	);