using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieRental.Domain.Entities;
using Nager.Country;

namespace MovieRental.Infrastructure.Configurations;

internal sealed class CountryOfOriginConfiguration : IEntityTypeConfiguration<CountryOfOrigin>
{
    public void Configure(EntityTypeBuilder<CountryOfOrigin> builder)
    {
        builder
            .HasKey(c => c.NameAlpha3Code);

        builder
            .Property(c => c.CommonName)
            .IsRequired();

        var countryProvider = new CountryProvider();

        var countries = countryProvider.GetCountries().Select((countryInfo) => 
        new CountryOfOrigin {
            NameAlpha3Code = Enum.GetName(countryInfo.Alpha3Code) ?? string.Empty,
            CommonName = countryInfo.CommonName
        }).ToList();

        builder
            .HasData(countries);
    }
}
