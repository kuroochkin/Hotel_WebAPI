using ErrorOr;
using Hotel.App.Common.Errors;
using Hotel.App.Common.Interfaces;
using Hotel.App.Room.Vm;
using MediatR;

namespace Hotel.App.Employee.Queries.GetEmployeeDetails;

public class GetEmployeeDetailsQueryHandler
    : IRequestHandler<GetEmployeeDetailsQuery, ErrorOr<EmployeeVm>>
{
    private readonly IUnitOfWork _unitOfWork;
    public GetEmployeeDetailsQueryHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<ErrorOr<EmployeeVm>> Handle(
        GetEmployeeDetailsQuery request,
        CancellationToken cancellationToken)
    {
        if (!Guid.TryParse(request.EmployeeId, out var employeeId))
        {
            return Errors.Employee.InvalidId;
        }

        var employee = await _unitOfWork.Employees.FindEmployeeWithJobtitle(employeeId);
        if (employee is null)
        {
            return Errors.Employee.NotFound;
        }

        var employeeModel = new EmployeeVm(
            employee.Id.ToString(),
            employee.LastName,
            employee.FirstName,
            employee.Patronymic,
            employee.Birthday,
            employee.Education,
            new JobtitleVm(
                employee.JobTitle.Id.ToString(),
                employee.JobTitle.JobTitle),
            employee.Salary
            );

        return employeeModel;
    }
}

