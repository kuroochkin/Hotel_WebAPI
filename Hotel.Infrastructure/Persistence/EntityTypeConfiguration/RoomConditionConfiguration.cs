using Hotel.Domain.Room;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Hotel.Infrastructure.Persistence.EntityTypeConfiguration;

public class RoomConditionConfiguration : IEntityTypeConfiguration<RoomConditionEntity>
{
	public void Configure(EntityTypeBuilder<RoomConditionEntity> builder)
	{
		builder.HasKey(room => room.Id);
		builder.HasOne(room => room.Employee);
		builder.HasOne(room => room.Booking);
		builder.Property(room => room.CheckIn);
		builder.Property(room => room.Departure);
		builder.Property(room => room.TotalPrice);
	}
}
