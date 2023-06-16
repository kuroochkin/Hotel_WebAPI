using Hotel.App.Common.Interfaces;
using Hotel.Infrastructure.Persistence.Repositories;
using Hotel.Infrastructure.Persistence;
using Hotel.Domain.JobTitle;

namespace Hotel.Infrastructure.Repositories;

public class JobtitleRepository : GenericRepository<JobtitleEntity>, IJobtitleRepository
{
	public JobtitleRepository(ApplicationDbContext context) : base(context)
	{
	}
}

