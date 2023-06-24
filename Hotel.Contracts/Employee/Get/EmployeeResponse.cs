using Hotel.Contracts.Jobtitle.Get;
using Hotel.Contracts.Room.Get;

namespace Hotel.Contracts.Employee.Get;

public record EmployeeResponse(
	string? Id,
	string? LastName,
	string? FirstName,
	string? Patronymic,
	DateTime? Birthday,
	string? Education,
	JobtitleResponse? JobTitle,
	decimal? Salary
	);
