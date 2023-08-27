using MovieRental.Domain.Enums;

namespace MovieRental.Domain.Entities;

public class User
{
    public Guid Id { get; set; }
    public string? Email  { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public DateOnly? DateOfBirth { get; set; }
    public string?  PasswordHash { get; set; }
    public Role Role { get; set; }

    public ICollection<Rental>? Rentals { get; set; }
}
