using Hotel.App.Common.Interfaces;
using Hotel.Infrastructure.Persistence.Repositories;
using Hotel.Infrastructure.Persistence;
using Hotel.Domain.Room;
using Microsoft.EntityFrameworkCore;
using static Hotel.Domain.Booking.BookingEntity;
using Hotel.Infrastructure.Persistence.Specifications;
using Hotel.Infrastructure.Persistence.Specifications.Room;
using Hotel.Infrastructure.Migrations;
using System.Diagnostics;
using System.Linq.Expressions;

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
		//return await _context.Rooms
		//	.Include(room => room.Category)
		//	.Include(room => room.Condition)
		//	.ThenInclude(condition => condition.Booking)
		//	.ThenInclude(booking => booking.Clients)
		//	.ToListAsync();

		return await _context.Rooms
			//ApplySpecification(new ConditionCategoryBookingClientsSpecification())
			.Include(room => room.Condition.Booking.Clients)
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

	public async Task<List<RoomEntity>?> FindFreeRooms()
	{
		return await 
			 ApplySpecification(new ConditionCategoryBookingSpecification())
			.Where(room => room.Condition.Booking.Status == BookingStatus.Free)
			.ToListAsync();
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
}