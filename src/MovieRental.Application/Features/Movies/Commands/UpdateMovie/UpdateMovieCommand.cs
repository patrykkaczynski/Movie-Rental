using AutoMapper;
using MediatR;
using MovieRental.Domain.Entities;
using MovieRental.Domain.Exceptions;
using MovieRental.Domain.Interfaces;

namespace MovieRental.Application.Features.Movies.Commands.UpdateMovie;

public record UpdateMovieCommand(
    Guid Id,
    string Title,
    string Description,
    string Genre,
    int RunTimeMin,
    string RegionOfOrigin,
    DateOnly ReleaseDate) : IRequest;

internal sealed class UpdateMovieCommandHandler : IRequestHandler<UpdateMovieCommand>
{
    private readonly IMapper _mapper;
    private readonly IMovieRepository _movieRepository;
    public UpdateMovieCommandHandler(IMapper mapper, IMovieRepository movieRepository)
    {
        _mapper = mapper;
        _movieRepository = movieRepository;
    }
    public async Task Handle(UpdateMovieCommand request, CancellationToken cancellationToken)
    {

        var existingMovie = await _movieRepository.GetByIdAsync(request.Id);

        if (existingMovie is null)
            throw new NotFoundException($"Movie does not exist with {request.Id} id");

        var newMovie = _mapper.Map<Movie>(request);

        await _movieRepository.UpdateAsync(existingMovie, newMovie);
    }
}