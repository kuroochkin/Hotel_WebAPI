using Hotel.Domain.Room;
using System.Linq.Expressions;

namespace Hotel.Infrastructure.Persistence.Specifications.Room;

public class ConditionCategoryBookingClientsSpecification : Specification<RoomEntity>
{
	public ConditionCategoryBookingClientsSpecification(Guid id) 
		: base(room => room.Id == id)
	{
		AddInclude(room => room.Category);
		AddInclude(room => room.Condition);
		AddInclude(room => room.Condition.Booking);
		AddInclude(room => room.Condition.Booking.Clients);
	}

	public ConditionCategoryBookingClientsSpecification()
	{
		AddInclude(room => room.Category);
		AddInclude(room => room.Condition);
		AddInclude(room => room.Condition.Booking);
		AddInclude(room => room.Condition.Booking.Clients);
	}
}
