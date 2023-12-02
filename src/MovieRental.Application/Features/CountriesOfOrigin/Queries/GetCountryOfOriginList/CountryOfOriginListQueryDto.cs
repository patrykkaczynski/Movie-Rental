
namespace MovieRental.Application.Features.CountriesOfOrigin.Queries.GetCountryOfOriginList;

public class CountryOfOriginListQueryDto
{
    public required string NameAlpha3Code { get; set; }
    public required string CommonName { get; set; }
}
