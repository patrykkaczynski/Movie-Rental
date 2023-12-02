using MovieRental.Domain.Entities;

namespace MovieRental.Domain.Interfaces;

public interface IFormatRepository
{
    Task<IEnumerable<Format>> GetAllAsync(CancellationToken cancellationToken);
}
