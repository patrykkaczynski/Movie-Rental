
namespace MovieRental.Domain.Exceptions;

public sealed class JwtKeyNullException : Exception
{
    public JwtKeyNullException(string message) : base(message)
    {
        
    }
}
