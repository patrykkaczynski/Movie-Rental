using MovieRental.Domain.Entities;
using MovieRental.Domain.Interfaces;
using MovieRental.Infrastructure.Persistence;

namespace MovieRental.Infrastructure.Repositories;

internal class ReviewRepository : IReviewRepository
{
    private readonly MovieRentalDbContext _dbContext;
    public ReviewRepository(MovieRentalDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<int> CreateAsync(Review review)
    {
        await _dbContext.Reviews.AddAsync(review);
        await _dbContext.SaveChangesAsync();

        return review.Id;
    }
}
