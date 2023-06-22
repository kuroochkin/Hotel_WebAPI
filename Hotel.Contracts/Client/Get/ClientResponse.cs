namespace Hotel.Contracts.Client.Get;

public record ClientResponse(
	string? Id,
	string? LastName,
	string? FirstName,
	string? Patronymic,
	DateTime? Birthday,
	string? Education,
	string Sex
	);
