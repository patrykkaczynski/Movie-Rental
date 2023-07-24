using FluentValidation;

namespace MovieRental.Application.Features.Accounts.Commands.LoginUser;

internal class LoginUserCommandValidator : AbstractValidator<LoginUserCommand>
{
    public LoginUserCommandValidator()
    {
        RuleFor(l => l.Email)
           .NotEmpty()
           .EmailAddress();

        RuleFor(l => l.Password)
            .NotEmpty();
    }
}
