using Microsoft.EntityFrameworkCore;
using MovieRental.Domain.Entities;
using MovieRental.Domain.Interfaces;
using MovieRental.Infrastructure.Persistence;

namespace MovieRental.Infrastructure.Repositories;

internal class AccountRepository : IAccountRepository
{
    private readonly MovieRentalDbContext _dbContext;

    public AccountRepository(MovieRentalDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task RegisterUserAsync(User user)
    {
        await _dbContext.Users.AddAsync(user);
        await _dbContext.SaveChangesAsync();
    }

    public async Task<bool> ValidateEmailAsync(string email)
    {
        return await _dbContext.Users.AnyAsync(u => u.Email == email);
    }

    public async Task<User?> GetUserAsync(string email)
    {

        return await _dbContext.Users
            .FirstOrDefaultAsync(u => u.Email == email);
    }
}
