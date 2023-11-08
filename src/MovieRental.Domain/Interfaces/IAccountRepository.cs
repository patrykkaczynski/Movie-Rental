using MovieRental.Domain.Entities;

namespace MovieRental.Domain.Interfaces;

public interface IAccountRepository
{
    Task RegisterUserAsync(User user);
    Task<bool> ValidateEmailAsync(string email);
    Task<bool> ValidateRoleAsync(int roleId);
    Task<User?> GetUserAsync(string email);
}
