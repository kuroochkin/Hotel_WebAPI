using ErrorOr;
using Hotel.App.Common.Interfaces;
using Hotel.Domain.CategoryRoom;
using MediatR;

namespace Hotel.App.CategoryRoom.Commands.CreateCategory;

public class CreateCategoryCommandHandler
	: IRequestHandler<CreateCategoryCommand, ErrorOr<bool>>
{
	private readonly IUnitOfWork _unitOfWork;

	public CreateCategoryCommandHandler(IUnitOfWork unitOfWork)
	{
		_unitOfWork = unitOfWork;
	}

	public async Task<ErrorOr<bool>> Handle(
		CreateCategoryCommand request,
		CancellationToken cancellationToken)
	{
		var category = new CategoryRoomEntity(
			request.Category,
			request.Description,
			request.QuantityPersons,
			request.QuantityRooms,
			request.Price);

		if (await _unitOfWork.CategoriesRooms.Add(category))
		{
			return await _unitOfWork.CompleteAsync();
		}

		return false;
	}
}
