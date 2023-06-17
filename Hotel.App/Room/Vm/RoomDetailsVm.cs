using Hotel.Domain.JobTitle;
using System.Security.Cryptography.X509Certificates;
using static Hotel.Domain.Booking.BookingEntity;

namespace Hotel.App.Room.Vm;

public record RoomDetailsVm(
	string Id,
	CategoryRoomVm Category,
	RoomConditionVm Condition,
	string Thumbnail);

public record CategoryRoomVm(
	string Id,
	string Category,
	int QuantityPersons,
	int QuantityRooms,
	string Description,
	decimal Price
	);

public record RoomConditionVm(
	string Id,
	EmployeeVm? Employee,
	BookingVm Booking,
	DateTime CheckIn,
	DateTime Departure,
	decimal TotalPrice
	);

public record BookingVm(
	string Id,
	BookingStatus Status
	//List<ClientVm> Clients
	);

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

public record ClientVm(
	string? Id,
	string? LastName,
	string? FirstName,
	string? Patronymic,
	DateTime? Birthday,
	string? Education,
	string Sex
	);

public record JobtitleVm(
	string Id,
	string JobTitle
	);

