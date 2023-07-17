namespace Hotel.App.Room.Vm;

public record ClientVm(
	string Id,
	string? LastName,
	string? FirstName,
	string? Patronymic,
	DateTime? Birthday,
	string Sex
	);