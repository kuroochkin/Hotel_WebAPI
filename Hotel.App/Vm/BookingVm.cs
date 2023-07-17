using AutoMapper;
using Hotel.App.Common.Mappings;
using Hotel.Domain.Booking;
using Hotel.Domain.CategoryRoom;
using static Hotel.Domain.Booking.BookingEntity;

namespace Hotel.App.Room.Vm;

public class BookingVm : IMapWith<BookingEntity>
{
	public string? Id { get; set; }
	public BookingStatus? Status { get; set; }
	public List<ClientVm> Clients { get; set; }

	public void Mapping(Profile profile)
	{
		profile.CreateMap<BookingEntity, BookingVm>();
	}
}
	