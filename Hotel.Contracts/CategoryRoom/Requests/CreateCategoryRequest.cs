
using System.Reflection.Metadata;

namespace Hotel.Contracts.CategoryRoom.Requests;

public record CreateCategoryRequest(
	string Category,
	string Description,
	int QuantityPersons,
	int QuantityRooms,
	decimal Price);
