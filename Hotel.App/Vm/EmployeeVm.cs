namespace Hotel.App.Room.Vm;

public record EmployeeVm(
	string? Id,
	string? LastName,
	string? FirstName,
	string? Patronymic,
	DateTime? Birthday,
	string? Education,
	JobtitleVm? JobTitle,
	decimal? Salary
	);