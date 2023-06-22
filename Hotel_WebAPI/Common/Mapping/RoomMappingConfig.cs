using Hotel.App.Room.Vm;
using Hotel.Contracts.Room.Get;
using Mapster;

namespace Hotel.API.Common.Mapping;

public class RoomMappingConfig : IRegister
{
	public void Register(TypeAdapterConfig config)
	{
		config.NewConfig<RoomsVm, GetRoomsResponse>()
			.Map(dest => dest.Rooms, src => src.Rooms);

		config.NewConfig<RoomDetailsVm, GetRoomDetailsResponse>()
			.Map(dest => dest.Id, src => src.Id)
			.Map(dest => dest.Category, src => src.Category)
			.Map(dest => dest.Condition, src => src.Condition)
			.Map(dest => dest.Thumbnail, src => src.Thumbnail);
	}
}
