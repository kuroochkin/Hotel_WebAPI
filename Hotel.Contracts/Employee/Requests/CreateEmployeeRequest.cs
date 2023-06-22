using Hotel.Contracts.Room.Get;

namespace Hotel.Contracts.Employee.Requests;

public record CreateEmployeeRequest(
	string LastName,
	string FirstName,
	string Patronymic,
	DateTime Birthday,
	string Education,
	string JobtitleId,
	decimal Salary
	);

