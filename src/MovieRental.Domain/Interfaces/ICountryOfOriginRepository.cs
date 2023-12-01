
using MovieRental.Domain.Entities;

namespace MovieRental.Domain.Interfaces;

public interface ICountryOfOriginRepository
{
    Task<IEnumerable<CountryOfOrigin>> GetAllAsync(CancellationToken cancellationToken);
}
