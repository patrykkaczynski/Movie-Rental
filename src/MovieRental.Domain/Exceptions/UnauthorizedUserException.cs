
namespace MovieRental.Domain.Exceptions;

public sealed class UnauthorizedUserException : Exception
{
    public UnauthorizedUserException(string message) : base(message)
    {

    }
}
