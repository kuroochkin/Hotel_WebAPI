using Hotel.App.Common.Interfaces;
using Hotel.Infrastructure.Persistence.Repositories;
using Hotel.Infrastructure.Persistence;
using Hotel.Domain.Client;

namespace Hotel.Infrastructure.Repositories;

public class ClientRepository : GenericRepository<ClientEntity>, IClientRepository
{
	public ClientRepository(ApplicationDbContext context) : base(context)
	{
	}
}