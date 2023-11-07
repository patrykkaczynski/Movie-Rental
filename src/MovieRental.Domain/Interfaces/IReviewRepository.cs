using MovieRental.Domain.Entities;

namespace MovieRental.Domain.Interfaces;

public interface IReviewRepository
{
    Task<int> CreateAsync(Review review);
}
