using Hotel.Domain.Booking;
using Hotel.Domain.Employee;

namespace Hotel.Domain.Room;

public class RoomConditionEntity
{
	public Guid Id { get; set; }
	public EmployeeEntity? Employee { get; set; }

	public BookingEntity Booking { get; set; }

	public DateTime CheckIn { get; set; }

	public DateTime Departure { get; set; }

	public decimal TotalPrice { get; set; }

	public RoomConditionEntity(BookingEntity booking, decimal totalPrice)
	{
		Id = Guid.NewGuid();
		CheckIn = DateTime.Now;
		Booking = booking;
		TotalPrice = totalPrice;
	}

	public RoomConditionEntity()
	{

	}
}
