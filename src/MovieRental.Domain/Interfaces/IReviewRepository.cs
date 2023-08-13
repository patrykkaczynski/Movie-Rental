using MovieRental.Domain.Entities;

namespace MovieRental.Domain.Interfaces;

public interface IReviewRepository
{
    Task<Guid> CreateAsync(Review review);
}
