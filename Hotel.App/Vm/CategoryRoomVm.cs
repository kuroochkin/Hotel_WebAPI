using AutoMapper;
using Hotel.App.Common.Mappings;
using Hotel.Domain.Booking;
using Hotel.Domain.CategoryRoom;
using Hotel.Domain.Employee;
using static Hotel.Domain.Booking.BookingEntity;

namespace Hotel.App.Room.Vm;

public class CategoryRoomVm : IMapWith<CategoryRoomEntity>
{
	public string? Id { get; set; }
	public string? Category { get; set; }
	public int? QuantityPersons { get; set; }
	public int? QuantityRooms { get; set; }
	public string? Description { get; set; }
	public decimal? Price { get; set; }

	public void Mapping(Profile profile)
	{
		profile.CreateMap<CategoryRoomEntity, CategoryRoomVm>();
	}
}

