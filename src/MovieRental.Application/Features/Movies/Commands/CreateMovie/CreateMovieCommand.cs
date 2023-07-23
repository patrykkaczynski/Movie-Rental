﻿using AutoMapper;
using FluentValidation;
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
    DateOnly ReleaseDate) : IRequest<Guid>;


internal sealed class CreateBookCommandHandler : IRequestHandler<CreateMovieCommand, Guid>
{
    private readonly IMapper _mapper;
    private readonly IMovieRepository _movieRepository;

    public CreateBookCommandHandler(IMapper mapper, IMovieRepository movieRepository)
    {
        _mapper = mapper;
        _movieRepository = movieRepository;
    }
    public async Task<Guid> Handle(CreateMovieCommand request, CancellationToken cancellationToken)
    {
        var validator = new CreateMovieCommandValidator();
        await validator.ValidateAndThrowAsync(request, cancellationToken);

        var movie = _mapper.Map<Movie>(request);

        return await _movieRepository.CreateAsync(movie);
    }
}