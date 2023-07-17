using AutoMapper;
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
    private readonly IMapper _mapper;

    public GetEmployeeDetailsQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
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

        var result = _mapper.Map<EmployeeVm>(employee);
        return result;
    }
}

