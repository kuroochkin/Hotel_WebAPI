using ErrorOr;
using Hotel.App.Room.Vm;
using MediatR;

namespace Hotel.App.Employee.Queries.GetEmployeeDetails;

public record GetEmployeeDetailsQuery(string EmployeeId) : IRequest<ErrorOr<EmployeeVm>>
{
}
