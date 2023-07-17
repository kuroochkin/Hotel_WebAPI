using AutoMapper;
using ErrorOr;
using Hotel.App.Common.Errors;
using Hotel.App.Common.Interfaces;
using Hotel.App.Room.Vm;
using MediatR;

namespace Hotel.App.Room.Queries.GetRoomsByCountSuite;

public class GetRoomsByCountSuiteQueryHandler
	: IRequestHandler<GetRoomsByCountSuiteQuery, ErrorOr<RoomsVm>>
{
	private readonly IUnitOfWork _unitOfWork;
	private readonly IMapper _mapper;

	public GetRoomsByCountSuiteQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
	{
		_unitOfWork = unitOfWork;
		_mapper = mapper;
	}

	public async Task<ErrorOr<RoomsVm>> Handle(
		GetRoomsByCountSuiteQuery request, 
		CancellationToken cancellationToken)
	{
		var rooms = await _unitOfWork.Rooms.FindRoomsByCountSuite(request.QuantitySuite);
		if (rooms is null)
		{
			return Errors.Room.NotFound;
		}

		var result = _mapper.Map<RoomsVm>(rooms);
		return result;
	}
}



