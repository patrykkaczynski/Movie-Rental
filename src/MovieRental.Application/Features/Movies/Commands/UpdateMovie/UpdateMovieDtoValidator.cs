﻿using FluentValidation;

namespace MovieRental.Application.Features.Movies.Commands.UpdateMovie;

internal sealed class UpdateMovieDtoValidator : AbstractValidator<UpdateMovieDto>
{
    public UpdateMovieDtoValidator()
    {

        RuleFor(m => m.Title)
            .MaximumLength(50)
            .NotEmpty();

        RuleFor(m => m.Description)
            .MaximumLength(150)
            .NotEmpty();

        RuleFor(m => m.Genre)
            .MaximumLength(50)
            .NotEmpty();

        RuleFor(m => m.RunTimeMin)
            .GreaterThan(0)
            .NotEmpty();

        RuleFor(m => m.RegionOfOrigin)
           .MaximumLength(50)
           .NotEmpty();

        RuleFor(m => m.ReleaseDate)
           .LessThan(DateOnly.FromDateTime(DateTime.Now))
           .NotEmpty();
    }
}
