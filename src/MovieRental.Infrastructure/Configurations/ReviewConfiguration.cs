using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieRental.Domain.Entities;

namespace MovieRental.Infrastructure.Configurations;

internal sealed class ReviewConfiguration : IEntityTypeConfiguration<Review>
{
    public void Configure(EntityTypeBuilder<Review> builder)
    {
        builder
            .Property(r => r.Description)
            .IsRequired();

        builder
            .Property(r => r.Rating)
            .IsRequired();

        builder
            .Property(r => r.CreatedBy)
            .IsRequired();

        builder
           .Property(r => r.CreationDate)
           .IsRequired();
    }
} 
