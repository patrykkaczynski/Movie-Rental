using AutoMapper;
using MovieRental.Application.Features.Movies.Commands.CreateMovie;
using MovieRental.Application.Features.Movies.Queries.GetMovieDetail;
using MovieRental.Application.Features.Movies.Queries.GetMovieList;
using MovieRental.Domain.Entities;

namespace MovieRental.Application.MappingProfiles;

public class MovieProfile : Profile
{
    public MovieProfile()
    {
        CreateMap<CreateMovieCommand, Movie>();

        CreateMap<Movie, MovieListQueryDto>();

        CreateMap<Movie, MovieDetailQueryDto>();
    }
}
