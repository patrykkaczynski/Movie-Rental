using MovieRental.Domain.Entities;

namespace MovieRental.Domain.Interfaces;

public interface IAccountRepository
{
    Task RegisterUserAsync(User user);
    Task<bool> ValidateEmailAsync(string email);
    Task<User?> GetUserAsync(string email);
}
