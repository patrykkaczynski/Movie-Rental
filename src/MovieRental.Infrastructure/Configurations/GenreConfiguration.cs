using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieRental.Domain.Entities;

namespace MovieRental.Infrastructure.Configurations;

internal sealed class GenreConfiguration : IEntityTypeConfiguration<Genre>
{
    public void Configure(EntityTypeBuilder<Genre> builder)
    {
        builder
            .Property(g => g.Name)
            .IsRequired();

        builder.HasData(
            new Genre
            {
                Id = 1,
                Name = "Action"
            },
            new Genre
            {
                Id = 2,
                Name = "Adventure"
            },
            new Genre
            {
                Id = 3,
                Name = "Animation"
            },
            new Genre
            {
                Id = 4,
                Name = "Biography"
            },
            new Genre
            {
                Id = 5,
                Name = "Comedy"
            },
            new Genre
            {
                Id = 6,
                Name = "Crime"
            },
            new Genre
            {
                Id = 7,
                Name = "Documentary"
            },
            new Genre
            {
                Id = 8,
                Name = "Drama"
            },
            new Genre
            {
                Id = 9,
                Name = "Family"
            },
            new Genre
            {
                Id = 10,
                Name = "Fantasy"
            },
            new Genre
            {
                Id = 11,
                Name = "Film-Noir"
            },
            new Genre
            {
                Id = 12,
                Name = "Game-Show"
            },
            new Genre
            {
                Id = 13,
                Name = "History"
            },
            new Genre
            {
                Id = 14,
                Name = "Horror"
            },
            new Genre
            {
                Id = 15,
                Name = "Music"
            },
            new Genre
            {
                Id = 16,
                Name = "Musical"
            },
            new Genre
            {
                Id = 17,
                Name = "Mystery"
            },
            new Genre
            {
                Id = 18,
                Name = "News"
            },
            new Genre
            {
                Id = 19,
                Name = "Reality-TV"
            },
            new Genre
            {
                Id = 20,
                Name = "Romance"
            },
            new Genre
            {
                Id = 21,
                Name = "Sci-Fi"
            },
            new Genre
            {
                Id = 22,
                Name = "Short"
            },
            new Genre
            {
                Id = 23,
                Name = "Sport"
            },
            new Genre
            {
                Id = 24,
                Name = "Talk-Show"
            },
            new Genre
            {
                Id = 25,
                Name = "Thriller"
            },
            new Genre
            {
                Id = 26,
                Name = "War"
            },
            new Genre
            {
                Id = 27,
                Name = "Western"
            });
    }
}
