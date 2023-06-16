using Hotel.App.Common.Interfaces;
using Hotel.Infrastructure.Persistence.Repositories;
using Hotel.Infrastructure.Persistence;
using Hotel.Domain.Room;

namespace Hotel.Infrastructure.Repositories;

public class RoomConditionRepository : GenericRepository<RoomConditionEntity>, IRoomConditionRepository
{
	public RoomConditionRepository(ApplicationDbContext context) : base(context)
	{
	}
}

