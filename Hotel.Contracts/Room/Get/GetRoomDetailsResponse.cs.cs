using static Hotel.Domain.Booking.BookingEntity;

namespace Hotel.Contracts.Room.Get
{
	public record GetRoomDetailsResponse(
	string Id,
	CategoryRoomResponse Category,
	RoomConditionResponse Condition,
	string Thumbnail);

	public record CategoryRoomResponse(
		string Id,
		string Category,
		int QuantityPersons,
		int QuantityRooms,
		string Description,
		decimal Price
		);

	public record RoomConditionResponse(
		string Id,
		EmployeeResponse? Employee,
		BookingResponse Booking,
		DateTime CheckIn,
		DateTime Departure,
		decimal TotalPrice
		);

	public record BookingResponse(
		string Id,
		BookingStatus Status,
		List<ClientResponse> Clients
		);

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

	public record ClientResponse(
		string? Id,
		string? LastName,
		string? FirstName,
		string? Patronymic,
		DateTime? Birthday,
		string? Education,
		string Sex
		);

	public record JobtitleResponse(
		string Id,
		string JobTitle
		);

}
