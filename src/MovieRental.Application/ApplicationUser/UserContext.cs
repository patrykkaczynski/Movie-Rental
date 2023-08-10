using Microsoft.AspNetCore.Http;
using MovieRental.Domain.Exceptions;
using System.Security.Claims;

namespace MovieRental.Application.ApplicationUser;

public interface IUserContext
{
    CurrentUser GetCurrentUser();
}
public class UserContext : IUserContext
{
    private readonly IHttpContextAccessor _httpContextAccessor;

    public UserContext(IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor;
    }
    public CurrentUser GetCurrentUser()
    {
        var user = (_httpContextAccessor?.HttpContext?.User) ?? throw new NotFoundException("Context user is not found");

        var fullname = user.FindFirst(c => c.Type == ClaimTypes.Name)!.Value;

        return new CurrentUser(fullname);
    }
}
