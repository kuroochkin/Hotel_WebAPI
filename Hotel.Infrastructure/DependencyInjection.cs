using Hotel.App.Common.Interfaces;
using Hotel.Infrastructure.Persistence;
using Hotel.Infrastructure.Persistence.Repositories;
using Hotel.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace Hotel.Infrastructure;

public static class DependencyInjection
{
	public static IServiceCollection AddInfrastructure(
		this IServiceCollection services,
		ConfigurationManager configuration)
	{
		services.AddScoped<IBookingRepository, BookingRepository>();
		services.AddScoped<ICategoryRoomRepository, CategoryRoomRepository>();
		services.AddScoped<IClientRepository, ClientRepository>();
		services.AddScoped<IEmployeeRepository, EmployeeRepository>();
		services.AddScoped<IJobtitleRepository, JobtitleRepository>();
		services.AddScoped<IRoomConditionRepository, RoomConditionRepository>();
		services.AddScoped<IRoomRepository, RoomRepository>();
		services.AddScoped<IUnitOfWork, UnitOfWork>();


		services.AddDbContext<ApplicationDbContext>(options =>
		{
			options.UseSqlServer(configuration.GetConnectionString("SqlServer"));
		});


		return services;
	}
}
