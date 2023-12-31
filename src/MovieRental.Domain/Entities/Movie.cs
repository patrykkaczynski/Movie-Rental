﻿
namespace MovieRental.Domain.Entities;

public class Movie
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public required string Description { get; set; }
    public TimeSpan Duration { get; set; }
    public DateOnly ReleaseDate { get; set; }

    public ICollection<Genre> Genres { get; set; } = new List<Genre>();
    public ICollection<CountryOfOrigin> CountriesOfOrigin { get; set; } = new List<CountryOfOrigin>();
    public ICollection<PhysicalMovie> PhysicalMovies { get; set; } = new List<PhysicalMovie>();
    public ICollection<Review> Reviews { get; set; } = new List<Review>();
}
