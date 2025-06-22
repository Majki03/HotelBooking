using Booking.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Booking.Domain.Repositories;

public class Repository(DataContext context) : IRepository
{
    public async Task<BookingModel> AddAsync(BookingModel booking)
    {
        await context.Bookings
            .AddAsync(booking);
        await context.SaveChangesAsync();

        return booking;
    }

    public async Task<IEnumerable<BookingModel>> GetAsync()
    {
        return await context.Bookings.ToListAsync();
    }

    public async Task<BookingModel?> GetByIdAsync(int id)
    {
        return await context.Bookings.FirstOrDefaultAsync(b => b.Id == id);
    }

    public async Task<BookingModel> UpdateAsync(BookingModel booking)
    {
        context.Bookings.Update(booking);
        await context.SaveChangesAsync();
        return booking;
    }
}
