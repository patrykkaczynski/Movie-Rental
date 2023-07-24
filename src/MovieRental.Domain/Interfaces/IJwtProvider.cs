using MovieRental.Domain.Entities;

namespace MovieRental.Domain.Interfaces;

public interface IJwtProvider
{
    string GenerateJwt(User user);
}
