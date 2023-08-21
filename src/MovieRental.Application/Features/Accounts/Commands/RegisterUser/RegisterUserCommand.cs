using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Identity;
using MovieRental.Domain.Entities;
using MovieRental.Domain.Interfaces;

namespace MovieRental.Application.Features.Accounts.Commands.RegisterUser;

public record RegisterUserCommand(
    string Email,
    string Password,
    string ConfirmPassword,
    string FirstName,
    string LastName,
    DateOnly DateOfBirth
    //string Role
    ) : IRequest;


internal sealed class RegisterUserCommandHandler : IRequestHandler<RegisterUserCommand>
{
    private readonly IMapper _mapper;
    private readonly IAccountRepository _accountRepository;
    private readonly IPasswordHasher<User> _passwordHasher;

    public RegisterUserCommandHandler(IMapper mapper, IAccountRepository accountRepository, IPasswordHasher<User> passwordHasher)
    {
        _mapper = mapper;
        _accountRepository = accountRepository;
        _passwordHasher = passwordHasher;
    }

    public async Task Handle(RegisterUserCommand request, CancellationToken cancellationToken)
    {

        var user = _mapper.Map<User>(request);

        var hashedPassword = _passwordHasher.HashPassword(user, request.Password);

        user.PasswordHash = hashedPassword;

        await _accountRepository.RegisterUserAsync(user);

    }
}