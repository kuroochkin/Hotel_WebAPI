using Hotel.API.Common.Mapping;

namespace Hotel.API;

public static class DependencyInjection
{
	public static IServiceCollection AddPresentation(this IServiceCollection services)
	{
		services.AddControllers();
		services.AddEndpointsApiExplorer();
		services.AddMappings();
		services.AddSwaggerGen();

		return services;
	}
}