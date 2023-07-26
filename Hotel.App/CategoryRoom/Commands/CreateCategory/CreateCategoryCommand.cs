using ErrorOr;
using MediatR;

namespace Hotel.App.CategoryRoom.Commands.CreateCategory;

public record CreateCategoryCommand(
	string Category,
	string Description,
	int QuantityPersons,
	int QuantityRooms,
	decimal Price) : IRequest<ErrorOr<bool>>;

