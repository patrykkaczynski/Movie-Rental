using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieRental.Domain.Entities;

namespace MovieRental.Infrastructure.Configurations;

internal sealed class FormatConfiguration : IEntityTypeConfiguration<Format>
{
    public void Configure(EntityTypeBuilder<Format> builder)
    {
        builder
            .Property(f => f.Name)
            .IsRequired();

        builder.HasData(
            new Format
            {
                Id = 1,
                Name = "4K"
            },
            new Format
            {
                Id = 2,
                Name = "Blu-ray"
            },
            new Format
            {
                Id = 3,
                Name = "DVD"
            });
    }
}
