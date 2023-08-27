using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieRental.Domain.Entities;

namespace MovieRental.Infrastructure.Configurations
{
    internal sealed class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(u => u.Email)
                .IsRequired();

            builder.Property(u => u.FirstName)
                .IsRequired();

            builder.Property(u => u.LastName)
                .IsRequired();

            builder.Property(u => u.DateOfBirth)
                .IsRequired();

            builder.Property(u => u.PasswordHash)
                .IsRequired();

            builder.Property(u => u.Role)
                .IsRequired()
                .HasConversion<string>();


        }

    }
}
