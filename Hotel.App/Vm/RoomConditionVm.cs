using AutoMapper;
using Hotel.App.Common.Mappings;
using Hotel.Domain.Employee;
using Hotel.Domain.Room;

namespace Hotel.App.Room.Vm;


public class RoomConditionVm : IMapWith<RoomConditionEntity>
{
	public string? Id { get; set; }
	public EmployeeVm? Employee { get; set; }
	public BookingVm? Booking { get; set; }
	public DateTime CheckIn { get; set; }
	public DateTime Departure { get; set; }
	public decimal TotalPrice { get; set; }

	public void Mapping(Profile profile)
	{
		profile.CreateMap<RoomConditionEntity, RoomConditionVm>();
	}
}
