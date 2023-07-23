using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Hotel.Domain.CategoryRoom;

namespace Hotel.Infrastructure.Persistence.EntityTypeConfiguration;

public class CategoryRoomConfiguration : IEntityTypeConfiguration<CategoryRoomEntity>
{
	public void Configure(EntityTypeBuilder<CategoryRoomEntity> builder)
	{
		builder.HasKey(category => category.Id);
		builder.Property(category => category.Category);
		builder.Property(category => category.QuantityPersons);
		builder.Property(category => category.QuantityRooms);
		builder.Property(category => category.Description);
		builder.Property(category => category.Price);
		builder.Property(category => category.Bathroom);
		builder.Property(category => category.AirConditioner);
		builder.Property(category => category.Fridge);
		builder.Property(category => category.HairDryer);
		builder.Property(category => category.Iron);
		builder.Property(category => category.Kettle);
		builder.Property(category => category.Tv);
		builder.Property(category => category.WiFi);
	}
}
