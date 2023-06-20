using ErrorOr;
using Hotel.App.Room.Vm;
using MediatR;

namespace Hotel.App.Employee.Queries;

public record GetEmployeeDetailsQuery(string EmployeeId) : IRequest<ErrorOr<EmployeeVm>>
{
}
