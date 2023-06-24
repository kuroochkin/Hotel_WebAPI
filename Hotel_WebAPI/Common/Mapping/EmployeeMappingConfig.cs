using Hotel.App.Room.Vm;
using Hotel.Contracts.Employee.Get;
using Mapster;

namespace Hotel.API.Common.Mapping;

public class EmployeeMappingConfig : IRegister
{
	public void Register(TypeAdapterConfig config)
	{
		config.NewConfig<EmployeeVm, EmployeeResponse>()
			.Map(dest => dest.Id, src => src.Id)
			.Map(dest => dest.LastName, src => src.FirstName)
			.Map(dest => dest.Patronymic, src => src.Patronymic)
			.Map(dest => dest.Birthday, src => src.Birthday)
			.Map(dest => dest.Education, src => src.Education)
			.Map(dest => dest.JobTitle, src => src.JobTitle)
			.Map(dest => dest.Salary, src => src.Salary);
	}
}
