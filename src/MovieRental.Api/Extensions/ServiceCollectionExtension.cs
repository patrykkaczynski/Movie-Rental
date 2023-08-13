using Hellang.Middleware.ProblemDetails;
using Microsoft.AspNetCore.Mvc;
using MovieRental.Api.Swagger;
using MovieRental.Domain.Exceptions;

namespace MovieRental.Api.Extensions;

public static class ServiceCollectionExtension
{
    public static IServiceCollection AddPresentation(this IServiceCollection services)
    {
        services.AddProblemDetails(options =>
        {
            options.IncludeExceptionDetails = (ctx, ex) => false;

            options.Map<InvalidCredentialsException>(exception => new ProblemDetails()
            {
                Type = StatusCodeProblemDetails.Create(400).Type,
                Title = StatusCodeProblemDetails.Create(400).Title,
                Status = StatusCodeProblemDetails.Create(400).Status,
                Detail = exception.Message
            });

            options.Map<NotFoundException>(exception => new ProblemDetails()
            {
                Type = StatusCodeProblemDetails.Create(404).Type,
                Title = StatusCodeProblemDetails.Create(404).Title,
                Status = StatusCodeProblemDetails.Create(404).Status,
                Detail = exception.Message
            });

            options.Map<Exception>(exception => new ProblemDetails()
            {
                Type = StatusCodeProblemDetails.Create(500).Type,
                Title = StatusCodeProblemDetails.Create(500).Title,
                Status = StatusCodeProblemDetails.Create(500).Status,
                Detail = exception.Message
            });
        });

        services.ConfigureSwagger();

        return services;
    }
}
