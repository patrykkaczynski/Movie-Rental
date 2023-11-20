
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieRental.Domain.Entities;

namespace MovieRental.Infrastructure.Configurations;

internal sealed class RentalConfiguration : IEntityTypeConfiguration<Rental>
{
    public void Configure(EntityTypeBuilder<Rental> builder)
    {
        builder
            .Property(r => r.RentalDate)
            .IsRequired();

        builder
           .Property(r => r.DueDate)
           .IsRequired();
    }
}
