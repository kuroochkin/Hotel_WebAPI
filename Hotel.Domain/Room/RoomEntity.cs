using Hotel.Domain.Booking;
using Hotel.Domain.Employee;

namespace Hotel.Domain.Room;

public class RoomEntity
{
	public Guid Id { get; set; }
	public EmployeeEntity Employee { get; set; }

	public BookingEntity Booking { get; set; }

	public DateTime CheckIn { get; set; }

	public DateTime Departure { get; set; }

	public decimal TotalPrice { get; set; }
}
