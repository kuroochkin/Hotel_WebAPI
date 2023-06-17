using Hotel.App.Common.Interfaces;
using Hotel.Infrastructure.Persistence.Repositories;
using Hotel.Infrastructure.Persistence;
using Hotel.Domain.Room;
using Microsoft.EntityFrameworkCore;

namespace Hotel.Infrastructure.Repositories;

public class RoomRepository : GenericRepository<RoomEntity>, IRoomRepository
{
	public RoomRepository(ApplicationDbContext context) : base(context)
	{
	}

	public async Task<RoomEntity?> FindRoomWithConditionAndCategory(Guid id)
	{
		return await _context.Rooms
			.Include(room => room.Category)
			.Include(room => room.Condition)
			.ThenInclude(condition => condition.Booking)
			.FirstOrDefaultAsync(room => room.Id == id);
	}

}