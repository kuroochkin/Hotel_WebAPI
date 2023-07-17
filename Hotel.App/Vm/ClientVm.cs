using AutoMapper;
using Hotel.App.Common.Mappings;
using Hotel.Domain.Client;
using Hotel.Domain.Employee;

namespace Hotel.App.Room.Vm;

public class ClientVm : IMapWith<ClientEntity>
{
	public string Id { get; set; }
	public string? LastName { get; set; }
	public string? FirstName { get; set; }
	public string? Patronymic { get; set; }
	public DateTime? Birthday { get; set; }
	public string Sex { get; set; }

	public void Mapping(Profile profile)
	{
		profile.CreateMap<ClientEntity, ClientVm>();
	}
}