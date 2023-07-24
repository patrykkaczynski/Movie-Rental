﻿namespace MovieRental.Domain.Entities;

public class User
{
    public Guid Id { get; set; }
    public string? Email  { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public DateOnly? DateOfBirth { get; set; }
    public string?  PasswordHash { get; set; }

    public int RoleId { get; set; }
    public Role? Role { get; set; }
}
