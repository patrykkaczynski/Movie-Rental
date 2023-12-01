using AutoMapper;
using MovieRental.Application.Features.CountriesOfOrigin.Queries.GetCountryOfOriginList;
using MovieRental.Domain.Entities;

namespace MovieRental.Application.MappingProfiles;

public class CountryOfOriginProfile : Profile
{
    public CountryOfOriginProfile()
    {
        CreateMap<CountryOfOrigin, CountryOfOriginListQueryDto>();
    }
}
