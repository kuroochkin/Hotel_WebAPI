using Hotel.App.Convenience.Commands.CreateConvenience;
using Hotel.App.Room.Vm;
using Hotel.Contracts.CategoryRoom.Get;
using Hotel.Contracts.Convenience.Requests;
using Mapster;

namespace Hotel.API.Common.Mapping;

public class ConvenienceMappingConfig : IRegister
{
	public void Register(TypeAdapterConfig config)
	{
		config.NewConfig<CreateConvenienceRequest, CreateConvenienceCommand>()
			.Map(dest => dest.Bathroom, src => src.Bathroom)
			.Map(dest => dest.Tv, src => src.Tv)
			.Map(dest => dest.AirConditioner, src => src.AirConditioner)
			.Map(dest => dest.Fridge, src => src.Fridge)
			.Map(dest => dest.HairDryer, src => src.HairDryer)
			.Map(dest => dest.Iron, src => src.Iron)
			.Map(dest => dest.Kettle, src => src.Kettle)
			.Map(dest => dest.WiFi, src => src.WiFi);
	}
}
