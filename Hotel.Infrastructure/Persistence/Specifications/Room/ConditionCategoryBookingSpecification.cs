using Hotel.Domain.Room;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace Hotel.Infrastructure.Persistence.Specifications.Room;
 
public class ConditionCategoryBookingSpecification : Specification<RoomEntity>
{
	public ConditionCategoryBookingSpecification(Expression<Func<RoomEntity, bool>>? criteria) : base(criteria)
	{
		AddInclude(room => room.Include(room => room.Category));
		AddInclude(room => room.Include(room => room.Condition)
			.ThenInclude(condition => condition.Booking));

	}

	public ConditionCategoryBookingSpecification()
	{
		AddInclude(room => room.Include(room => room.Category));
		AddInclude(room => room.Include(room => room.Condition)
			.ThenInclude(condition => condition.Booking));
	}
}
