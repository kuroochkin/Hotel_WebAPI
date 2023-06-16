using Hotel.App.Common.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Hotel.Infrastructure.Persistence.Repositories;

public class UnitOfWork : IUnitOfWork, IDisposable
{
	private readonly ApplicationDbContext _context;

	public UnitOfWork(ApplicationDbContext context,
		IBookingRepository bookings,
		ICategoryRoomRepository categoriesRooms,
		IClientRepository clients,
		IEmployeeRepository employees,
		IJobtitleRepository jobtitles,
		IRoomConditionRepository roomCondition,
		IRoomRepository rooms)
	{
		_context = context;
		Bookings = bookings;
		CategoriesRooms = categoriesRooms;
		Clients = clients;
		Employees = employees;
		Jobtitles = jobtitles;
		RoomConditions = roomCondition;
		Rooms = rooms;
	}
	public IBookingRepository Bookings { get; }

	public ICategoryRoomRepository CategoriesRooms { get; }

	public IClientRepository Clients { get; }

	public IEmployeeRepository Employees { get; }

	public IJobtitleRepository Jobtitles { get; }

	public IRoomConditionRepository RoomConditions { get; }

	public IRoomRepository Rooms { get; }

	public async Task<bool> CompleteAsync()
	{
		return await _context.SaveChangesAsync() > 0;
	}
	public void Dispose()
	{
		_context.Dispose();
	}
}
