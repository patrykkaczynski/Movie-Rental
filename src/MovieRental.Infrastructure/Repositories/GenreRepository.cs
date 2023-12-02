using Microsoft.EntityFrameworkCore;
using MovieRental.Domain.Entities;
using MovieRental.Domain.Interfaces;
using MovieRental.Infrastructure.Persistence;

namespace MovieRental.Infrastructure.Repositories;

public class GenreRepository : IGenreRepository
{
    private readonly MovieRentalDbContext _dbContext;
    public GenreRepository(MovieRentalDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task<IEnumerable<Genre>> GetAllAsync(CancellationToken cancellationToken)
    {
        return await _dbContext.Genres.AsNoTracking().ToListAsync(cancellationToken);
    }
}
