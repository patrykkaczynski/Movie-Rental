using Microsoft.EntityFrameworkCore;
using MovieRental.Domain.Entities;
using MovieRental.Domain.Interfaces;
using MovieRental.Infrastructure.Persistence;

namespace MovieRental.Infrastructure.Repositories;

public class CountryOfOriginRepository : ICountryOfOriginRepository
{
    private readonly MovieRentalDbContext _dbContext;
    public CountryOfOriginRepository(MovieRentalDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<IEnumerable<CountryOfOrigin>> GetAllAsync(CancellationToken cancellationToken)
    {
        return await _dbContext.CountriesOfOrigin.AsNoTracking().ToListAsync(cancellationToken);
    }
}
