using ErrorOr;
using MediatR;

namespace Hotel.App.CategoryRoom.Commands.AddConvenience;

public class AddConvenienceCommandHandler
	: IRequestHandler<AddConvenienceCommand, ErrorOr<bool>>
{
	public async Task<ErrorOr<bool>> Handle(
		AddConvenienceCommand request, 
		CancellationToken cancellationToken)
	{
		if (!Guid.TryParse(request.CategoryId, out var categoryId))
		{
			return Errors.Jobtitle.InvalidId;
		}

		if (!Guid.TryParse(request.ConvenienceId, out var convenienceId))
		{
			return Errors.Jobtitle.InvalidId;
		}
	}
}
