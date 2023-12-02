using MovieRental.Domain.Entities;

namespace MovieRental.Domain.Interfaces;

public interface IGenreRepository
{
    Task<IEnumerable<Genre>> GetAllAsync(CancellationToken cancellationToken);
}
