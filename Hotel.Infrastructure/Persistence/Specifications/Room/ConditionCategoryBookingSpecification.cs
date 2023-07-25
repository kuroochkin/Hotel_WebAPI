using Hotel.Domain.Room;
using System.Linq.Expressions;

namespace Hotel.Infrastructure.Persistence.Specifications.Room;
 
public class ConditionCategoryBookingSpecification : Specification<RoomEntity>
{
	public ConditionCategoryBookingSpecification(Expression<Func<RoomEntity, bool>>? criteria) : base(criteria)
	{
		AddInclude(room => room.Category);
		AddInclude(room => room.Condition);
		AddInclude(room => room.Condition.Booking);
	}

	public ConditionCategoryBookingSpecification()
	{
		AddInclude(room => room.Category);
		AddInclude(room => room.Condition);
		AddInclude(room => room.Condition.Booking);
	}
}
