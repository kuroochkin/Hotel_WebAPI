using Hotel.App.Room.Vm;
using Hotel.Contracts.Room.Get;
using Hotel.Contracts.RoomCondition.Get;
using Mapster;

namespace Hotel.API.Common.Mapping;

public class RoomConditionMappingConfig : IRegister
{
	public void Register(TypeAdapterConfig config)
	{
		config.NewConfig<RoomConditionVm, RoomConditionResponse>()
			.Map(dest => dest.Id, src => src.Id)
			.Map(dest => dest.Employee, src => src.Employee)
			.Map(dest => dest.Booking, src => src.Booking)
			.Map(dest => dest.CheckIn, src => src.CheckIn)
			.Map(dest => dest.Departure, src => src.Departure)
			.Map(dest => dest.TotalPrice, src => src.TotalPrice);
	}
}

