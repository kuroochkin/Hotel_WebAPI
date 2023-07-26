using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Hotel.Domain.CategoryRoom;

namespace Hotel.Infrastructure.Persistence.EntityTypeConfiguration;

public class CategoryRoomConfiguration : IEntityTypeConfiguration<CategoryRoomEntity>
{
	public void Configure(EntityTypeBuilder<CategoryRoomEntity> builder)
	{
		builder.HasKey(category => category.Id);
		builder.HasOne(category => category.Convenience);
		builder.Property(category => category.Category);
		builder.Property(category => category.QuantityPersons);
		builder.Property(category => category.QuantityRooms);
		builder.Property(category => category.Description);
		builder.Property(category => category.Price);


	}
}
