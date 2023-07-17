using AutoMapper;
using Hotel.App.Common.Mappings;
using Hotel.Domain.JobTitle;
using Hotel.Domain.Room;

namespace Hotel.App.Room.Vm;


public class JobtitleVm : IMapWith<JobtitleEntity>
{
	public string? Id { get; set; }
	public string? JobTitle { get; set; }

	public void Mapping(Profile profile)
	{
		profile.CreateMap<JobtitleEntity, JobtitleVm>();
	}
}

