using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Hotel.App.Common.Errors;
using Hotel.App.Common.Interfaces;
using Hotel.App.Room.Queries.GetRoomsByCountPersons;
using Hotel.App.Room.Vm;
using ErrorOr;
using Hotel.Domain.Booking;
using MediatR;

namespace Hotel.App.Room.Queries.GetRoomsByBookingStatus
{
    public class GetRoomsByBookingStatusQueryHandler
        : IRequestHandler<GetRoomsByBookingStatusQuery, ErrorOr<RoomsVm>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetRoomsByBookingStatusQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ErrorOr<RoomsVm>> Handle(
            GetRoomsByBookingStatusQuery request,
            CancellationToken cancellationToken)
        {
            BookingEntity.BookingStatus bookingStatus = (BookingEntity.BookingStatus)Enum.Parse(typeof(BookingEntity.BookingStatus), request.bookingStatus);

            var rooms = await _unitOfWork.Rooms.FindRoomsByBookingStatus(bookingStatus);
            if (rooms is null)
            {
                return Errors.Room.NotFound;
            }

            var result = _mapper.Map<RoomsVm>(rooms);
            return result;
        }
    }
}
