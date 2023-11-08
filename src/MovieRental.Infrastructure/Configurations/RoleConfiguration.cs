using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieRental.Domain.Entities;

namespace MovieRental.Infrastructure.Configurations;

internal sealed class RoleConfiguration : IEntityTypeConfiguration<Role>
{
    public void Configure(EntityTypeBuilder<Role> builder)
    {
        builder.Property(r => r.Name)
            .IsRequired();

        builder.HasData(
            new Role()
            {
                Id = 1,
                Name = "Client"
            },
            new Role()
            {
                Id = 2,
                Name = "Employee"
            },
            new Role()
            {
                Id = 3,
                Name = "Manager"
            });
    }
}
