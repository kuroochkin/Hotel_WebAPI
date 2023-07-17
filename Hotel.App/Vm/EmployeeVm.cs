using AutoMapper;
using Hotel.App.Common.Mappings;
using Hotel.Domain.Employee;
using Hotel.Domain.Room;

namespace Hotel.App.Room.Vm;

public class EmployeeVm : IMapWith<EmployeeEntity>
{
	public string? Id { get; set; }
	public string? LastName { get; set; }
	public string? FirstName { get; set; }
	public string? Patronymic { get; set; }
	public DateTime? Birthday{ get; set; }
	public string? Education { get; set; }
	public JobtitleVm? JobTitle { get; set; }
	public decimal? Salary { get; set; }

	public void Mapping(Profile profile)
	{
		profile.CreateMap<EmployeeEntity, EmployeeVm>();
	}
}
