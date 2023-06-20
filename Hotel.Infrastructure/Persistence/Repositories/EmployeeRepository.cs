using Hotel.App.Common.Interfaces;
using Hotel.Infrastructure.Persistence.Repositories;
using Hotel.Infrastructure.Persistence;
using Hotel.Domain.Employee;
using Microsoft.EntityFrameworkCore;

namespace Hotel.Infrastructure.Repositories;

public class EmployeeRepository : GenericRepository<EmployeeEntity>, IEmployeeRepository
{
	public EmployeeRepository(ApplicationDbContext context) : base(context)
	{
	}

	public async Task<EmployeeEntity?> FindEmployeeWithJobtitle(Guid id)
	{
		return await _context.Employees
			.Include(employee => employee.JobTitle)
			.FirstOrDefaultAsync(employee => employee.Id == id);
	}
}