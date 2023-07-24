using Microsoft.AspNetCore.Mvc;
using MovieRental.Api.Middlewares;
using MovieRental.Api.Swagger;

namespace MovieRental.Api.Extensions;

public static class ServiceCollectionExtension
{
    public static IServiceCollection AddPresentation(this IServiceCollection services)
    {

        services.ConfigureSwagger();
        services.AddScoped<ExceptionMiddleware>();
        return services;
    }
}
