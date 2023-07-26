using Hotel.App.Common.Interfaces;
using Hotel.Domain.Сonveniences;

namespace Hotel.Infrastructure.Persistence.Repositories;

public class ConvenienceRepository : GenericRepository<СonvenienceEntity>, IConvenienceRepository
{
	public ConvenienceRepository(ApplicationDbContext context) : base(context)
	{
	}
}


