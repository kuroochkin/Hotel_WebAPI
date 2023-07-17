using AutoMapper;
using Hotel.App.Common.Mappings;
using Hotel.Domain.Room;

namespace Hotel.App.Room.Vm;

public class RoomsVm : IMapWith<List<RoomEntity>>
{
	public List<RoomDetailsVm> Rooms { get; set; }

	public void Mapping(Profile profile)
	{
		profile.CreateMap<List<RoomEntity>, RoomsVm>()
			.ForMember(roomsVm => roomsVm.Rooms,
				opt => opt.MapFrom(source => source));
	}
}
	

public class RoomDetailsVm : IMapWith<RoomEntity>
{
	public Guid Id { get; set; }
	public CategoryRoomVm? Category { get; set; }

	public RoomConditionVm? Condition { get; set; }

	public string? Thumbnail { get; set; }

	public void Mapping(Profile profile)
	{
		profile.CreateMap<RoomEntity, RoomDetailsVm>();
	}
}





