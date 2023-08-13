using AutoMapper;
using MovieRental.Application.Features.Accounts.Commands.RegisterUser;
using MovieRental.Application.Features.Movies.Commands.CreateMovie;
using MovieRental.Application.Features.Movies.Commands.UpdateMovie;
using MovieRental.Application.Features.Movies.Queries.GetMovieDetail;
using MovieRental.Application.Features.Movies.Queries.GetMovieList;
using MovieRental.Application.Features.Reviews.Commands;
using MovieRental.Application.Features.Reviews.Queries;
using MovieRental.Domain.Entities;

namespace MovieRental.Application.MappingProfiles;

public class MovieProfile : Profile
{
    public MovieProfile()
    {
        CreateMap<CreateMovieCommand, Movie>();

        CreateMap<Movie, MovieListQueryDto>();

        CreateMap<Movie, MovieDetailQueryDto>();

        CreateMap<UpdateMovieCommand, Movie>();

        CreateMap<RegisterUserCommand, User>();

        CreateMap<CreateReviewCommand, Review>();

        CreateMap<Review,  ReviewListQueryDto>();

    }
}
