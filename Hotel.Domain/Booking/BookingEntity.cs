using Hotel.Domain.Client;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hotel.Domain.Booking;

public class BookingEntity
{
	public Guid Id { get; set; }

	public BookingStatus Status { get; set; }

	public BookingStatus GetStatus => Status;

	public string GetStatusBooking()
	{
		switch (Status)
		{
			case BookingStatus.Free:
				return "Free";
			case BookingStatus.Booked:
				return "Booked";
			case BookingStatus.Accommodation:
				return "Accommodation";
		}

		return "";
	}

	public enum BookingStatus
	{
		Free,
		Booked,
		Accommodation
	};

	public List<ClientEntity> Clients = new();
}
