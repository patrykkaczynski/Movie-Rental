using FluentValidation;
using MovieRental.Application.Features.Accounts.Commands.RegisterUser.ValidatorHelpers;
using MovieRental.Domain.Interfaces;

namespace MovieRental.Application.Features.Accounts.Commands.RegisterUser;

internal sealed class RegisterUserCommandValidator : AbstractValidator<RegisterUserCommand>
{
    public RegisterUserCommandValidator(IAccountRepository accountRepository)
    {
        RuleFor(r => r.Email)
            .NotEmpty()
            .EmailAddress()
            .Custom( (value, context) =>
            {
                var emailInUse =  accountRepository.ValidateEmailAsync(value).Result;
                if(emailInUse)
                {
                    context.AddFailure("Email", "That email is taken");
                }
            });

        RuleFor(r => r.Password).MinimumLength(6);

        RuleFor(r => r.Password)
            .NotEmpty()
            .MinimumLength(6)
            .Must(PasswordHelper.HasNumber).WithMessage("'Password' must contain at least one digit")
            .Must(PasswordHelper.HasCapitalLetter).WithMessage("'Password' must contain at least one capital letter")
            .Must(PasswordHelper.HasSmallLetter).WithMessage("'Password' must contain at least one small letter")
            .Must(PasswordHelper.HasSpecialCharacters).WithMessage("'Password' must contain at least one special character");

        RuleFor(r => r.ConfirmPassword)
            .Equal(e => e.Password);

        RuleFor(r => r.DateOfBirth)
            .NotEmpty()
            .ExclusiveBetween(DateOnly.FromDateTime(DateTime.Now).AddYears(-125), DateOnly.FromDateTime(DateTime.Now));

        RuleFor(r => r.RoleId)
            .NotEmpty()
            .Custom((value, context) =>
            {
                var roleInUse = accountRepository.ValidateRoleAsync(value).Result;
                if(!roleInUse)
                {
                    context.AddFailure("RoleId", "The role does not exist with this Id");
                }
            });
    }
}


