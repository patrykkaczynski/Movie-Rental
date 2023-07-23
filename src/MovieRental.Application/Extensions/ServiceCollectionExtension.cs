using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using MovieRental.Application.Features.Movies.Commands.CreateMovie;
using System.Reflection;

namespace MovieRental.Application.Extensions;

public static class ServiceCollectionExtension
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddMediatR(options
            => options.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));

        services.AddAutoMapper(Assembly.GetExecutingAssembly());

        services.AddValidatorsFromAssemblyContaining<CreateMovieCommandValidator>();
        ValidatorOptions.Global.LanguageManager.Enabled = false;

        return services;
    }
}
