using Hotel.App.Room.Vm;
using Hotel.Contracts.Jobtitle.Get;
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

