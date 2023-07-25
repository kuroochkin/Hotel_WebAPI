using AutoMapper;
using ErrorOr;
using Hotel.App.Common.Errors;
using Hotel.App.Common.Interfaces;
using Hotel.App.Room.Vm;
using MediatR;
using System.Diagnostics;

namespace Hotel.App.Room.Queries.GetAllRooms;
public class GetAllRoomsQueryHandler
    : IRequestHandler<GetAllRoomsQuery, ErrorOr<RoomsVm>>

{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public GetAllRoomsQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<ErrorOr<RoomsVm>> Handle(
        GetAllRoomsQuery request, 
        CancellationToken cancellationToken)
    {
		Stopwatch stopwatch = new Stopwatch();
		stopwatch.Start();
		var rooms = await _unitOfWork.Rooms.FindAllRooms();
        stopwatch.Stop();
		Console.WriteLine(stopwatch.ElapsedMilliseconds);
		if (rooms is null)
        {
            return Errors.Room.NotFound;
        }

		var result = _mapper.Map<RoomsVm>(rooms);
		return result;
	}
}
