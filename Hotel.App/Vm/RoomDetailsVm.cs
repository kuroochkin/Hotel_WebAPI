using Hotel.Domain.JobTitle;
using System.Security.Cryptography.X509Certificates;
using static Hotel.Domain.Booking.BookingEntity;

namespace Hotel.App.Room.Vm;

public record RoomsVm(
	List<RoomDetailsVm> Rooms);

public record RoomDetailsVm(
	string Id,
	CategoryRoomVm? Category,
	RoomConditionVm? Condition,
	string? Thumbnail);

