using Hotel.App.Common.Interfaces;
using Hotel.Infrastructure.Persistence.Repositories;
using Hotel.Infrastructure.Persistence;
using Hotel.Domain.CategoryRoom;

namespace Hotel.Infrastructure.Repositories;

public class CategoryRoomRepository : GenericRepository<CategoryRoomEntity>, ICategoryRoomRepository
{
	public CategoryRoomRepository(ApplicationDbContext context) : base(context)
	{
	}
}
