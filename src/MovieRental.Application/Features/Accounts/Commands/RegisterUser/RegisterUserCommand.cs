using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Identity;
using MovieRental.Domain.Entities;
using MovieRental.Domain.Enums;
using MovieRental.Domain.Interfaces;
using System.Diagnostics.Tracing;
using System.Text.Json.Serialization;

namespace MovieRental.Application.Features.Accounts.Commands.RegisterUser;

public record RegisterUserCommand(
    string Email,
    string Password,
    string ConfirmPassword,
    string FirstName,
    string LastName,
    DateOnly DateOfBirth,
    [property: JsonConverter(typeof(JsonStringEnumConverter))] Role Role
    ) : IRequest;

//public class RegisterUserCommand : IRequest
//{
//    public string? Email { get; set; }
//    public string? Password { get; set; }
//    public string? ConfirmPassword { get; set; }
//    public string? FirstName { get; set; }
//    public string? LastName { get; set; }
//    public DateOnly DateOfBirth { get; set; }

//    [JsonConverter(typeof(JsonStringEnumConverter))]
//    public Role Role { get; set; }
//}

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

        //var role = await _roleRepository.GetRoleByNameAsync(request.RoleName);
        //user.RoleId = role.Id;

        await _accountRepository.RegisterUserAsync(user);

    }
}