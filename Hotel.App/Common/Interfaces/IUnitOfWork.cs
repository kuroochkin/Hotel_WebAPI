namespace Hotel.App.Common.Interfaces;

public interface IUnitOfWork
{
	IBookingRepository Bookings { get; }
	ICategoryRoomRepository CategoriesRooms { get; }
	IClientRepository Clients { get; }
	IEmployeeRepository Employees { get; }
	IJobtitleRepository Jobtitles { get; }
	IRoomConditionRepository RoomConditions { get; }
	IRoomRepository Rooms { get; }
	Task<bool> CompleteAsync();
}
