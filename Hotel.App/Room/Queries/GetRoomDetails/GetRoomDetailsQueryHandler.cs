using AutoMapper;
using ErrorOr;
using Hotel.App.Common.Errors;
using Hotel.App.Common.Interfaces;
using Hotel.App.Room.Vm;
using MediatR;

namespace Hotel.App.Room.Queries.GetRoomDetails;

public class GetRoomDetailsQueryHandler
	: IRequestHandler<GetRoomDetailsQuery, ErrorOr<RoomDetailsVm>>
{
	private readonly IUnitOfWork _unitOfWork;
	private readonly IMapper _mapper;

	public GetRoomDetailsQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
	{
		_unitOfWork = unitOfWork;
		_mapper = mapper;
	}

	public async Task<ErrorOr<RoomDetailsVm>> Handle(
		GetRoomDetailsQuery request, 
		CancellationToken cancellationToken)
	{
		if (!Guid.TryParse(request.RoomId, out var roomId))
		{
			return Errors.Room.InvalidId;
		}

		var room = await _unitOfWork.Rooms.FindRoomWithConditionAndCategory(roomId);
		if(room is null)
		{
			return Errors.Room.NotFound;
		}

		var result = _mapper.Map<RoomDetailsVm>(room);
		return result;
	}
}
