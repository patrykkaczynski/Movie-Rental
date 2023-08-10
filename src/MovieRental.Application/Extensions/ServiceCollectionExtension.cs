using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using MovieRental.Application.ApplicationUser;
using MovieRental.Application.Features.Accounts.Commands.RegisterUser;
using MovieRental.Application.Features.Movies.Commands.CreateMovie;
using MovieRental.Application.Features.Movies.Commands.UpdateMovie;
using MovieRental.Application.Features.Reviews.Commands;
using MovieRental.Domain.Entities;
using System.Reflection;

namespace MovieRental.Application.Extensions;

public static class ServiceCollectionExtension
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        //User Context
        services.AddHttpContextAccessor();
        services.AddScoped<IUserContext, UserContext>();

        //MediatR
        services.AddMediatR(options
            => options.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));

        //Automapper
        services.AddAutoMapper(Assembly.GetExecutingAssembly());

        //FluentValidation
        services.AddScoped<IValidator<RegisterUserCommand>, RegisterUserCommandValidator>();
        services.AddScoped<IValidator<CreateMovieCommand>, CreateMovieCommandValidator>();
        services.AddScoped<IValidator<UpdateMovieDto>, UpdateMovieDtoValidator>();
        services.AddScoped<IValidator<CreateReviewDto>, CreateReviewDtoValidator>();
        services.AddValidatorsFromAssemblyContaining<CreateMovieCommandValidator>()
            .AddFluentValidationAutoValidation();
        ValidatorOptions.Global.LanguageManager.Enabled = false;

        //PasswordHasher
        services.AddScoped<IPasswordHasher<User>, PasswordHasher<User>>();

        return services;
    }
}
