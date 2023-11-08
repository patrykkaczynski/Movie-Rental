﻿
namespace MovieRental.Domain.Entities;

public class Role
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public ICollection<User> Users = new List<User>();
}
