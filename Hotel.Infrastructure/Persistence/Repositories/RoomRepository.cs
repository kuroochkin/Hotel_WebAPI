using Hotel.App.Common.Interfaces;
using Hotel.Infrastructure.Persistence.Repositories;
using Hotel.Infrastructure.Persistence;
using Hotel.Domain.Room;
using Microsoft.EntityFrameworkCore;
using static Hotel.Domain.Booking.BookingEntity;

namespace Hotel.Infrastructure.Repositories;

public class RoomRepository : GenericRepository<RoomEntity>, IRoomRepository
{
	public RoomRepository(ApplicationDbContext context) : base(context)
	{
	}

	public async Task<List<RoomEntity>?> FindAllRooms()
	{
		return await _context.Rooms
			.Include(room => room.Category)
			.Include(room => room.Condition)
			.ThenInclude(condition => condition.Booking)
			.ThenInclude(booking => booking.Clients)
			.ToListAsync();
    }

    public async Task<RoomEntity?> FindRoomWithConditionAndCategory(Guid id)
	{
		return await _context.Rooms
			.Include(room => room.Category)
			.Include(room => room.Condition)
			.ThenInclude(condition => condition.Booking)
			.ThenInclude(booking => booking.Clients)
			.FirstOrDefaultAsync(room => room.Id == id);
	}

	public async Task<List<RoomEntity>?> FindFreeRooms()
	{
		return await _context.Rooms
			.Include(room => room.Category)
			.Include(room => room.Condition)
			.ThenInclude(condition => condition.Booking)
			.Where(room => room.Condition.Booking.Status == BookingStatus.Free)
			.ToListAsync();
	}

	public async Task<List<RoomEntity>?> FindRoomsByCountSuite(int quantitySuite)
	{
		return await _context.Rooms
			.Include(room => room.Category)
			.Include(room => room.Condition)
			.ThenInclude(condition => condition.Booking)
			.Where(room => room.Category.QuantityRooms == quantitySuite)
			.ToListAsync();
	}

	public async Task<List<RoomEntity>?> FindRoomsByCountPersons(int quantityPersons)
	{
		return await _context.Rooms
			.Include(room => room.Category)
			.Include(room => room.Condition)
			.ThenInclude(condition => condition.Booking)
			.Where(room => room.Category.QuantityPersons == quantityPersons)
			.ToListAsync();
	}

}