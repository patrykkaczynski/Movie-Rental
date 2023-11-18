using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieRental.Domain.Entities;

namespace MovieRental.Infrastructure.Configurations;

internal sealed class MovieConfiguration : IEntityTypeConfiguration<Movie>
{
    public void Configure(EntityTypeBuilder<Movie> builder)
    {
        builder.Property(m => m.Title)
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(m => m.Description)
            .HasMaxLength(150)
            .IsRequired();

        builder.Property(m => m.ReleaseDate)
          .IsRequired();

        builder.Property(m => m.Duration)
            .IsRequired();
    }
}

