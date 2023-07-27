using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Hotel.Domain.Booking;

namespace Hotel.Infrastructure.Persistence.EntityTypeConfiguration;

public class BookingConfiguration : IEntityTypeConfiguration<BookingEntity>
{
	public void Configure(EntityTypeBuilder<BookingEntity> builder)
	{
		builder.HasKey(booking => booking.Id);
		builder.HasMany(booking => booking.Clients);
		builder.Property(booking => booking.Status);
	}
}
