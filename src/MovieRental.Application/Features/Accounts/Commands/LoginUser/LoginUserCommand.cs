using MediatR;
using Microsoft.AspNetCore.Identity;
using MovieRental.Domain.Entities;
using MovieRental.Domain.Exceptions;
using MovieRental.Domain.Interfaces;

namespace MovieRental.Application.Features.Accounts.Commands.LoginUser;

public record LoginUserCommand(
    string Email,
    string Password) : IRequest<string>;

internal sealed class LoginUserCommandHandler : IRequestHandler<LoginUserCommand, string>
{
    private readonly IAccountRepository _accountRepository;
    private readonly IPasswordHasher<User> _passwordHasher;
    private readonly IJwtProvider _jwtProvider;

    public LoginUserCommandHandler(IAccountRepository accountRepository, IPasswordHasher<User> passwordHasher, IJwtProvider jwtProvider)
    {
        _accountRepository = accountRepository;
        _passwordHasher = passwordHasher;
        _jwtProvider = jwtProvider;
    }
    public async Task<string> Handle(LoginUserCommand request, CancellationToken cancellationToken)
    {
        var user = await _accountRepository.GetUserAsync(request.Email) ?? throw new BadRequestException("Invalid username or password");

        var result = _passwordHasher.VerifyHashedPassword(user, user.PasswordHash, request.Password);

        if(result == PasswordVerificationResult.Failed)
            throw new BadRequestException("Invalid username or password");

        return _jwtProvider.GenerateJwt(user);
    }

}
