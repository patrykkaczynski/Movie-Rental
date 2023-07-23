using Microsoft.EntityFrameworkCore;
using MovieRental.Domain.Entities;
using MovieRental.Domain.Interfaces;
using MovieRental.Infrastructure.Persistence;
using System.Runtime.CompilerServices;

namespace MovieRental.Infrastructure.Repositories;

public class MovieRepository : IMovieRepository
{
    private readonly MovieRentalDbContext _dbContext;

    public MovieRepository(MovieRentalDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task<IEnumerable<Movie>> GetAllAsync()
    {
        return await _dbContext.Movies.AsNoTracking().ToListAsync();
    }

    public async Task<Movie?> GetByIdAsync(Guid id)
    {
        return await _dbContext.Movies.FirstOrDefaultAsync(m => m.Id == id);
    }

    public async Task<Guid> CreateAsync(Movie movie)
    {
        await _dbContext.AddAsync(movie);
        await _dbContext.SaveChangesAsync();

        return movie.Id;
    }

    public Task UpdateAsync(Movie movie)
    {
        throw new NotImplementedException();
    }

    public async Task DeleteAsync(Movie movie)
    {
        _dbContext.Movies.Remove(movie);
        await _dbContext.SaveChangesAsync();
    }
}
