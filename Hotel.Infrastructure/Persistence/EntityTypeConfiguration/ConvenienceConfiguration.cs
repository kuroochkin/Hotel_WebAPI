using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Hotel.Domain.Сonveniences;

namespace Hotel.Infrastructure.Persistence.EntityTypeConfiguration;

public class СonvenienceConfiguration : IEntityTypeConfiguration<СonvenienceEntity>
{
	public void Configure(EntityTypeBuilder<СonvenienceEntity> builder)
	{
		builder.HasKey(convenience => convenience.Id);

		builder.Property(convenience => convenience.AirConditioner);
		builder.Property(convenience => convenience.Fridge);
		builder.Property(convenience => convenience.HairDryer);
		builder.Property(convenience => convenience.Iron);
		builder.Property(convenience => convenience.Kettle);
		builder.Property(convenience => convenience.Tv);
		builder.Property(convenience => convenience.WiFi);
		builder.Property(convenience => convenience.Bathroom);
	}
}
