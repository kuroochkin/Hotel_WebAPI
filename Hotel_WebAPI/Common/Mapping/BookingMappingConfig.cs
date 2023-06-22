using Hotel.App.Room.Commands.CreateBooking;
using Hotel.App.Room.Vm;
using Hotel.Contracts.Room.Get;
using Hotel.Contracts.Room.Requests;
using Mapster;

namespace Hotel.API.Common.Mapping;

public class BookingMappingConfig : IRegister
{
	public void Register(TypeAdapterConfig config)
	{
		config.NewConfig<BookingVm, BookingResponse>()
			.Map(dest => dest.Id, src => src.Id)
			.Map(dest => dest.Status, src => src.Status);

		config.NewConfig<CreateBookingRequest, CreateBookingCommand>()
			.Map(dest => dest.RoomId, src => src.roomId)
			.Map(dest => dest.TotalPrice, src => src.totalPrice);
	}
}
