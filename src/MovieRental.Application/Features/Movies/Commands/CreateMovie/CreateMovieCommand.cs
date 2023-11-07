using AutoMapper;
using MediatR;
using MovieRental.Domain.Entities;
using MovieRental.Domain.Interfaces;

namespace MovieRental.Application.Features.Movies.Commands.CreateMovie;

public record CreateMovieCommand(
    string Title,
    string Description,
    string Genre,
    int RunTimeMin,
    string RegionOfOrigin,
    DateOnly ReleaseDate
      ) : IRequest<int>;


internal sealed class CreateBookCommandHandler : IRequestHandler<CreateMovieCommand, int>
{
    private readonly IMapper _mapper;
    private readonly IMovieRepository _movieRepository;

    public CreateBookCommandHandler(IMapper mapper, IMovieRepository movieRepository)
    {
        _mapper = mapper;
        _movieRepository = movieRepository;
    }
    public async Task<int> Handle(CreateMovieCommand request, CancellationToken cancellationToken)
    {
        var movie = _mapper.Map<Movie>(request);

        return await _movieRepository.CreateAsync(movie);
    }
}

