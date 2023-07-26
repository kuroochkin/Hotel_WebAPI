using ErrorOr;
using Hotel.App.Common.Interfaces;
using Hotel.Domain.Сonveniences;
using MediatR;

namespace Hotel.App.Convenience.Commands.CreateConvenience;

public class CreateConvenienceCommandHandler
	: IRequestHandler<CreateConvenienceCommand, ErrorOr<bool>>
{
	private readonly IUnitOfWork _unitOfWork;

	public CreateConvenienceCommandHandler(IUnitOfWork unitOfWork)
	{
		_unitOfWork = unitOfWork;
	}
	public async Task<ErrorOr<bool>> Handle(
		CreateConvenienceCommand request, 
		CancellationToken cancellationToken)
	{
		var convenience = new СonvenienceEntity(
			request.Bathroom,
			request.Tv,
			request.AirConditioner,
			request.Fridge,
			request.HairDryer,
			request.Kettle,
			request.Iron,
			request.WiFi);

		if (await _unitOfWork.Conveniences.Add(convenience))
		{
			return await _unitOfWork.CompleteAsync();
		}

		return false;
	}
}
