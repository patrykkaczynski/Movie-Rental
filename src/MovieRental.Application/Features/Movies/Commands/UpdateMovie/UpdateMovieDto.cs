
namespace MovieRental.Application.Features.Movies.Commands.UpdateMovie;

public record UpdateMovieDto(
    string Title,
    string Description,
    string Genre,
    int RunTimeMin,
    string RegionOfOrigin,
    DateOnly ReleaseDate);
