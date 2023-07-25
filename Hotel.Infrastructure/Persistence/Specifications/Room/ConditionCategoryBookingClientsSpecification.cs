using Hotel.Domain.Room;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Hotel.Infrastructure.Persistence.Specifications.Room;

public class ConditionCategoryBookingClientsSpecification : Specification<RoomEntity>
{
	public ConditionCategoryBookingClientsSpecification(Guid id) 
		: base(room => room.Id == id)
	{
		AddInclude(room => room.Include(room => room.Category));
		AddInclude(room => room.Include(room => room.Condition)
			.ThenInclude(condition => condition.Booking)
			.ThenInclude(booking => booking.Clients));
	}

	public ConditionCategoryBookingClientsSpecification()
	{
		AddInclude(room => room.Include(room => room.Category));
		AddInclude(room => room.Include(room => room.Condition)
			.ThenInclude(condition => condition.Booking)
			.ThenInclude(booking => booking.Clients));
	}
}
