using Hotel.App.Common.Interfaces;
using Hotel.Infrastructure.Persistence.Repositories;
using Hotel.Infrastructure.Persistence;
using Hotel.Domain.Room;
using Microsoft.EntityFrameworkCore;
using static Hotel.Domain.Booking.BookingEntity;
using Hotel.Infrastructure.Persistence.Specifications;
using Hotel.Infrastructure.Persistence.Specifications.Room;

namespace Hotel.Infrastructure.Repositories;

public class RoomRepository : GenericRepository<RoomEntity>, IRoomRepository
{ 
	public RoomRepository(ApplicationDbContext context) : base(context)
	{
	}

	private IQueryable<RoomEntity> ApplySpecification(
		Specification<RoomEntity> specification)
	{
		return SpecificationEvaluator.GetQuery(
			_context.Rooms,
			specification);
	}

	public async Task<List<RoomEntity>?> FindAllRooms()
	{
		return await 
			ApplySpecification(new ConditionCategoryBookingClientsSpecification())
			.ToListAsync();
	}

	public async Task<RoomEntity?> FindRoomWithConditionAndCategory(
		Guid id, 
		CancellationToken cancellationToken = default)
	{
		return await 
			 ApplySpecification(new ConditionCategoryBookingClientsSpecification(id))
			.FirstOrDefaultAsync(cancellationToken);
	}


	public async Task<List<RoomEntity>?> FindRoomsByCountSuite(int quantitySuite)
	{
		return await
			 ApplySpecification(new ConditionCategoryBookingSpecification())
			.Where(room => room.Category.QuantityRooms == quantitySuite)
			.ToListAsync();
	}

	public async Task<List<RoomEntity>?> FindRoomsByCountPersons(int quantityPersons)
	{
		return await 
			 ApplySpecification(new ConditionCategoryBookingSpecification())
			.Where(room => room.Category.QuantityPersons == quantityPersons)
			.ToListAsync();
	}

    public async Task<List<RoomEntity>?> FindRoomsByBookingStatus(BookingStatus status)
    {
		return await
			ApplySpecification(new ConditionCategoryBookingClientsSpecification())
				.Where(room => room.Condition.Booking.Status == status)
				.ToListAsync();
	}
}