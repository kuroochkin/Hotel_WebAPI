using Hotel.App.Common.Interfaces;
using Hotel.Infrastructure.Persistence.Repositories;
using Hotel.Infrastructure.Persistence;
using Hotel.Domain.Room;

namespace Hotel.Infrastructure.Repositories;

public class RoomRepository : GenericRepository<RoomEntity>, IRoomRepository
{
	public RoomRepository(ApplicationDbContext context) : base(context)
	{
	}
}