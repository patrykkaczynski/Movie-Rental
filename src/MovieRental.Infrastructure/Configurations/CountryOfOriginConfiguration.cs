using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieRental.Domain.Entities;
using Nager.Country;

namespace MovieRental.Infrastructure.Configurations;

public class CountryOfOriginConfiguration : IEntityTypeConfiguration<CountryOfOrigin>
{
    public void Configure(EntityTypeBuilder<CountryOfOrigin> builder)
    {
        builder
            .Property(c => c.CommonName)
            .IsRequired();

        builder
            .Property(c => c.NameAlpha3Code)
            .IsRequired()
            .HasMaxLength(3);

        var countryProvider = new CountryProvider();

        var countries = countryProvider.GetCountries().Select((countryInfo, index) => 
        new CountryOfOrigin { 
            Id = index + 1, 
            CommonName = countryInfo.CommonName,
            NameAlpha3Code = Enum.GetName(countryInfo.Alpha3Code) ?? string.Empty
        }).ToList();

        builder
            .HasData(countries);
    }
}
