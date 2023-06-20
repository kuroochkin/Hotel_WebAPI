using Hotel.Domain.Employee;

namespace Hotel.App.Common.Interfaces;

public interface IEmployeeRepository : IGenericRepository<EmployeeEntity>
{
	Task<EmployeeEntity?> FindEmployeeWithJobtitle(Guid id);
}
