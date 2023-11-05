﻿using MovieRental.Domain.Enums;

namespace MovieRental.Domain.Entities;

public class User
{
    public Guid Id { get; private set; }
    public required string Email { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public DateOnly DateOfBirth { get; set; }
    public required string PasswordHash { get; set; }
    public Role Role { get; set; }

    public ICollection<Rental> Rentals { get; set; } = new List<Rental>();
}
