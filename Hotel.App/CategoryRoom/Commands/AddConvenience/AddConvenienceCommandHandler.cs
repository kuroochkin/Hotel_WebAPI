using ErrorOr;
using Hotel.App.Common.Errors;
using Hotel.App.Common.Interfaces;
using MediatR;

namespace Hotel.App.CategoryRoom.Commands.AddConvenience;

public class AddConvenienceCommandHandler
	: IRequestHandler<AddConvenienceCommand, ErrorOr<bool>>
{
	private readonly IUnitOfWork _unitOfWork;

	public AddConvenienceCommandHandler(IUnitOfWork unitOfWork)
	{
		_unitOfWork = unitOfWork;
	}
	public async Task<ErrorOr<bool>> Handle(
		AddConvenienceCommand request, 
		CancellationToken cancellationToken)
	{
		if (!Guid.TryParse(request.CategoryId, out var categoryId))
		{
			return Errors.Category.InvalidId;
		}

		if (!Guid.TryParse(request.ConvenienceId, out var convenienceId))
		{
			return Errors.Convenience.InvalidId;
		}

		var category = await _unitOfWork.CategoriesRooms.FindCategoryRoomWithConvenience(categoryId);
		if(category is null)
		{
			return Errors.Category.NotFound;
		}

		var convenience = await _unitOfWork.Conveniences.FindById(convenienceId);
		if(convenience is null)
		{
			return Errors.Convenience.NotFound;
		}

		category.Convenience = convenience;

		return await _unitOfWork.CompleteAsync();
	}
}
