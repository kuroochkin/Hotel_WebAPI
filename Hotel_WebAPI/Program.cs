using Hotel.API;
using Hotel.App;
using Hotel.App.Common.Interfaces;
using Hotel.App.Common.Mappings;
using Hotel.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
{
	builder.Services
		.AddApplication()
		.AddInfrastructure(builder.Configuration)
		.AddPresentation();


	builder.Services
		.AddCors(options =>
		{
			options.AddPolicy("AllowAllHeaders", builder =>
			{
				builder.AllowAnyOrigin()
					   .AllowAnyHeader()
					   .AllowAnyMethod();
			});
		});

	builder.Services
		.AddAutoMapper(config =>
		{
			config.AddProfile(new AssemblyMappingProfile(typeof(IUnitOfWork).Assembly));
		});
}

var app = builder.Build();
{
	if (app.Environment.IsDevelopment())
	{
		app.UseSwagger();
		app.UseSwaggerUI();
	}
	app.UseCors("AllowAllHeaders");

	app.UseHttpsRedirection();

	app.MapControllers();

	app.Run();
}