using Hotel.Domain.Room;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hotel.Infrastructure.Persistence.EntityTypeConfiguration;

public class RoomConfiguration : IEntityTypeConfiguration<RoomEntity>
{
	public void Configure(EntityTypeBuilder<RoomEntity> builder)
	{
		builder.HasKey(room => room.Id);
		builder.HasOne(room => room.Category);
		builder.HasOne(room => room.Condition);
		builder.Property(room => room.Thumbnail);
	}
}
