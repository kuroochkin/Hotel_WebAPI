using Hotel.App.Room.Vm;
using Hotel.Contracts.Room.Get;
using Mapster;

namespace Hotel.API.Common.Mapping;

public class CategoryRoomMappingConfig : IRegister
{
	public void Register(TypeAdapterConfig config)
	{
		config.NewConfig<CategoryRoomVm, CategoryRoomResponse>()
			.Map(dest => dest.Id, src => src.Id)
			.Map(dest => dest.Category, src => src.Category)
			.Map(dest => dest.Description, src => src.Description)
			.Map(dest => dest.QuantityPersons, src => src.QuantityPersons)
			.Map(dest => dest.QuantityRooms, src => src.QuantityRooms)
			.Map(dest => dest.QuantityRooms, src => src.QuantityRooms)
			.Map(dest => dest.Price, src => src.Price);
	}
}
