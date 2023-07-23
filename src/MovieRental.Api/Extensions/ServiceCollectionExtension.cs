using MovieRental.Api.Middlewares;

namespace MovieRental.Api.Extensions;

public static class ServiceCollectionExtension
{
    public static IServiceCollection AddPresentation(this IServiceCollection services)
    {
        services.AddSwaggerGen();
        services.AddScoped<ExceptionMiddleware>();
        return services;
    }
}
