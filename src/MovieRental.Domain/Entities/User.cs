﻿
namespace MovieRental.Domain.Entities;

public class User
{
    public int Id { get; set; }
    public required string Email { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public DateOnly DateOfBirth { get; set; }
    public required string PasswordHash { get; set; }

    public int RoleId { get; set; }
    public Role? Role { get; set; }

    public ICollection<Rental> Rentals { get; set; } = new List<Rental>();
}
