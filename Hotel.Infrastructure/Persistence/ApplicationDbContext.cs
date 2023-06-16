using Hotel.Domain.Booking;
using Hotel.Domain.CategoryRoom;
using Hotel.Domain.Client;
using Hotel.Domain.Employee;
using Hotel.Domain.JobTitle;
using Hotel.Domain.Room;
using Hotel.Infrastructure.Persistence.EntityTypeConfiguration;
using Microsoft.EntityFrameworkCore;

namespace Hotel.Infrastructure.Persistence;

public class ApplicationDbContext : DbContext
{
	public DbSet<BookingEntity> Bookings { get; set; }
	public DbSet<CategoryRoomEntity> CategoriesRooms { get; set; }
	public DbSet<ClientEntity> Clients { get; set; }
	public DbSet<EmployeeEntity> Employees { get; set; }
	public DbSet<JobtitleEntity> Jobtitles { get; set; }
	public DbSet<RoomEntity> Rooms { get; set; }
	public DbSet<RoomConditionEntity> RoomConditions { get; set; }

	public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
	   : base(options) { }

	protected override void OnModelCreating(ModelBuilder builder)
	{
		builder.ApplyConfiguration(new BookingConfiguration());
		builder.ApplyConfiguration(new CategoryRoomConfiguration());
		builder.ApplyConfiguration(new ClientConfiguration());
		builder.ApplyConfiguration(new EmployeeConfiguration());
		builder.ApplyConfiguration(new JobtitleConfiguration());
		builder.ApplyConfiguration(new RoomConfiguration());
		builder.ApplyConfiguration(new RoomConditionConfiguration());

		base.OnModelCreating(builder);
	}
}
