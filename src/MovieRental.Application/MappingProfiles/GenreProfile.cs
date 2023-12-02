using AutoMapper;
using MovieRental.Application.Features.Genres.Queries.GetGenreList;
using MovieRental.Domain.Entities;

namespace MovieRental.Application.MappingProfiles;

public class GenreProfile : Profile
{
    public GenreProfile()
    {
        CreateMap<Genre, GenreListQueryDto>();
    }
}
