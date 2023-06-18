namespace Hotel.Contracts.Room.Requests;

public record CreateBookingRequest(
	string roomId,
	decimal totalPrice,
	List<GetClientsRequest> Clients);

public record GetClientsRequest(
	string? LastName,
	string? FirstName,
	string? Patronymic,
	DateTime Birthday,
	string? Education,
	string Sex);
