using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieRental.Domain.Entities;

namespace MovieRental.Infrastructure.Configurations;

internal sealed class PhysicalMovieConfiguration : IEntityTypeConfiguration<PhysicalMovie>
{
    public void Configure(EntityTypeBuilder<PhysicalMovie> builder)
    {
        builder
            .Property(p => p.Quantity)
            .IsRequired();

        builder
            .HasOne(p => p.Format)
            .WithMany(f => f.PhysicalMovies)
            .HasForeignKey(p => p.FormatId);

        builder
            .HasMany(p => p.Rentals)
            .WithOne(r => r.PhysicalMovie)
            .HasForeignKey(r => r.PhysicalMovieId);
    }
}
