namespace Hotel.Contracts.Room.Requests;

public record CreateBookingRequest(
	string roomId,
	decimal totalPrice);
