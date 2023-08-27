using Microsoft.EntityFrameworkCore;
using MovieRental.Domain.Entities;
using MovieRental.Domain.Interfaces;
using MovieRental.Infrastructure.Persistence;

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
        return await _dbContext.Movies
            .Include(m => m.Reviews)
            .FirstOrDefaultAsync(m => m.Id == id);
    }

    public async Task<Guid> CreateAsync(Movie movie)
    {
        await _dbContext.Movies.AddAsync(movie);
        await _dbContext.SaveChangesAsync();

        return movie.Id;
    }

    public async Task UpdateAsync(Movie existingMovie, Movie newMovie)
    {
        existingMovie.Title = newMovie.Title;
        existingMovie.Description = newMovie.Description;
        existingMovie.Genre = newMovie.Genre;
        existingMovie.RunTimeMin = newMovie.RunTimeMin;
        existingMovie.RegionOfOrigin = newMovie.RegionOfOrigin;
        existingMovie.ReleaseDate = newMovie.ReleaseDate;

        await _dbContext.SaveChangesAsync();

    }

    public async Task DeleteAsync(Movie movie)
    {
        _dbContext.Movies.Remove(movie);
        await _dbContext.SaveChangesAsync();
    }
}
