using Hotel.Domain.CategoryRoom;

namespace Hotel.App.Common.Interfaces;

public interface ICategoryRoomRepository : IGenericRepository<CategoryRoomEntity>
{
	Task<CategoryRoomEntity?> FindCategoryRoomWithConvenience(Guid id);
}
