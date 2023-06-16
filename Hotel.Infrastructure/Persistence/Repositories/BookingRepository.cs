using Hotel.App.Common.Interfaces;
using Hotel.Domain.Booking;
using Hotel.Infrastructure.Persistence;
using Hotel.Infrastructure.Persistence.Repositories;

namespace Hotel.Infrastructure.Repositories;

public class BookingRepository : GenericRepository<BookingEntity>, IBookingRepository
{
	public BookingRepository(ApplicationDbContext context) : base(context)
	{
	}
}

