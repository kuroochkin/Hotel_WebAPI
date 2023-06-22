using ErrorOr;
using Hotel.Contracts.Employee.Requests;
using MediatR;

namespace Hotel.App.Employee.Commands.CreateEmployee;

public record CreateEmployeeCommand(
	string LastName,
	string FirstName,
	string Patronymic,
	DateTime Birthday,
	string Education,
	string JobtitleId,
	decimal Salary) : IRequest<ErrorOr<bool>>;
