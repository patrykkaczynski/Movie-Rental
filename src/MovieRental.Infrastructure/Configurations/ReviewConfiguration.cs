using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieRental.Domain.Entities;

namespace MovieRental.Infrastructure.Configurations;

internal sealed class ReviewConfiguration : IEntityTypeConfiguration<Review>
{
    public void Configure(EntityTypeBuilder<Review> builder)
    {

        //many to one relation (Reviews - Book)
        builder
            .HasOne(r => r.Movie)
            .WithMany(b => b.Reviews)
            .HasForeignKey(r => r.MovieId);

        //one to many relation (Review - Responses)
        builder
            .HasMany(r => r.Responses)
            .WithOne(rp => rp.Review)
            .HasForeignKey(rp => rp.ReviewId);
    }
} 
