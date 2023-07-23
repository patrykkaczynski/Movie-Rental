using MediatR;
using MovieRental.Domain.Exceptions;
using MovieRental.Domain.Interfaces;

namespace MovieRental.Application.Features.Movies.Commands.DeleteMovie;

public record DeleteMovieCommand(Guid Id) : IRequest;

internal sealed class DeleteMovieCommandHandler : IRequestHandler<DeleteMovieCommand>
{
    private readonly IMovieRepository _movieRepository;

    public DeleteMovieCommandHandler(IMovieRepository movieRepository)
    {
        _movieRepository = movieRepository;
    }
    public async Task Handle(DeleteMovieCommand request, CancellationToken cancellationToken)
    {
        var movie = await _movieRepository.GetByIdAsync(request.Id);

        if (movie is null)
            throw new NotFoundException($"Movie does not exist with {request.Id}");

        await _movieRepository.DeleteAsync(movie);

    }
}
