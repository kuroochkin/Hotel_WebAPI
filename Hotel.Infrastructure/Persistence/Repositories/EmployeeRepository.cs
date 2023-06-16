using Hotel.App.Common.Interfaces;
using Hotel.Infrastructure.Persistence.Repositories;
using Hotel.Infrastructure.Persistence;
using Hotel.Domain.Employee;

namespace Hotel.Infrastructure.Repositories;

public class EmployeeRepository : GenericRepository<EmployeeEntity>, IEmployeeRepository
{
	public EmployeeRepository(ApplicationDbContext context) : base(context)
	{
	}
}