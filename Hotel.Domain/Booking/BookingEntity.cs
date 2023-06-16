using Hotel.Domain.Client;

namespace Hotel.Domain.Booking;

public class BookingEntity
{
	public Guid Id { get; set; }

	public enum BookingStatus
	{
		Free,
		Booked,
		Accommodation
	};

	public List<ClientEntity> Clients = new();
}
