using Hotel.App.Room.Commands.CreateBooking;
using Hotel.App.Room.Vm;
using Hotel.Contracts.Room.Get;
using Hotel.Contracts.Room.Requests;
using Mapster;

namespace Hotel.API.Common.Mapping;

public class JobtitleMappingConfig : IRegister
{
	public void Register(TypeAdapterConfig config)
	{
		config.NewConfig<JobtitleVm, JobtitleResponse>()
			.Map(dest => dest.Id, src => src.Id)
			.Map(dest => dest.JobTitle, src => src.JobTitle);
	}
}

