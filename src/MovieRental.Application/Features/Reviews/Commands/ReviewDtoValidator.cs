
using FluentValidation;

namespace MovieRental.Application.Features.Reviews.Commands;

internal sealed class ReviewDtoValidator : AbstractValidator<ReviewDto>
{
    public ReviewDtoValidator()
    {
        RuleFor(r => r.Description)
           .MaximumLength(200)
           .NotEmpty();

        RuleFor(r => r.Rating)
            .InclusiveBetween(1, 10)
            .NotEmpty();
    }
}
