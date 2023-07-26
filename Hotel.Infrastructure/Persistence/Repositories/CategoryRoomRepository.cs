using Hotel.App.Common.Interfaces;
using Hotel.Infrastructure.Persistence.Repositories;
using Hotel.Infrastructure.Persistence;
using Hotel.Domain.CategoryRoom;
using Microsoft.EntityFrameworkCore;

namespace Hotel.Infrastructure.Repositories;

public class CategoryRoomRepository : GenericRepository<CategoryRoomEntity>, ICategoryRoomRepository
{
	public CategoryRoomRepository(ApplicationDbContext context) : base(context)
	{
	}

	public async Task<CategoryRoomEntity?> FindCategoryRoomWithConvenience(Guid id)
	{
		return await _context.CategoriesRooms
			.Include(category => category.Convenience)
			.FirstOrDefaultAsync(category => category.Id == id);
	}
}
