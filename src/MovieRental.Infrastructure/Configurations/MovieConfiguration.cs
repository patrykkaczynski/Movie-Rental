using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieRental.Domain.Entities;

namespace MovieRental.Infrastructure.Configurations;

internal sealed class MovieConfiguration : IEntityTypeConfiguration<Movie>
{
    public void Configure(EntityTypeBuilder<Movie> builder)
    {
        builder
            .Property(m => m.Title)
            .HasMaxLength(50)
            .IsRequired();

        builder
            .Property(m => m.Description)
            .HasMaxLength(150)
            .IsRequired();

        builder
            .Property(m => m.ReleaseDate)
            .IsRequired();

        builder
            .Property(m => m.Duration)
            .IsRequired();

        builder
            .HasMany(m => m.Genres)
            .WithMany(g => g.Movies);

        builder
            .HasMany(m => m.CountriesOfOrigin)
            .WithMany(c => c.Movies);

        builder
            .HasMany(m => m.PhysicalMovies)
            .WithOne(p => p.Movie)
            .HasForeignKey(p => p.MovieId);

        builder
            .HasMany(m => m.Reviews)
            .WithOne(r => r.Movie)
            .HasForeignKey(r => r.MovieId);
    }
}

