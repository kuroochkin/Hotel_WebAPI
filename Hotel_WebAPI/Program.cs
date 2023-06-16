using Hotel.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
{
	builder.Services
		.AddInfrastructure(builder.Configuration);


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
}

var app = builder.Build();
{
	app.UseCors("AllowAllHeaders");

	app.UseHttpsRedirection();

	//app.MapControllers();

	app.Run();
}