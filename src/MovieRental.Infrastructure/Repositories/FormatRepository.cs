using Microsoft.EntityFrameworkCore;
using MovieRental.Domain.Entities;
using MovieRental.Domain.Interfaces;
using MovieRental.Infrastructure.Persistence;

namespace MovieRental.Infrastructure.Repositories;

public class FormatRepository : IFormatRepository
{
    private readonly MovieRentalDbContext _dbContext;

    public FormatRepository(MovieRentalDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<IEnumerable<Format>> GetAllAsync(CancellationToken cancellationToken)
    {
        return await _dbContext.Formats.AsNoTracking().ToListAsync(cancellationToken);
    }
}
