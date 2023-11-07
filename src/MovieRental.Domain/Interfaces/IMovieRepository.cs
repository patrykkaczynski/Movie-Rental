using MovieRental.Domain.Entities;

namespace MovieRental.Domain.Interfaces;

public interface IMovieRepository
{
    Task<IEnumerable<Movie>> GetAllAsync();
    Task<Movie?> GetByIdAsync(int id);
    Task<int> CreateAsync(Movie movie);
    Task UpdateAsync(Movie existingMovie, Movie newMovie);
    Task DeleteAsync(Movie movie);
}
