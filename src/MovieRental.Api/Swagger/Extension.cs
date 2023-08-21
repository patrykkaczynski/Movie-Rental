using Microsoft.OpenApi.Models;
using MovieRental.Api.Swagger.ParameterFilters;

namespace MovieRental.Api.Swagger;

public static class Extension
{
    public static void ConfigureSwagger(this IServiceCollection services)
    {
        services.AddSwaggerGen(options =>
        {
            // Adding of authorization feature. This feature consists of an "Autorize" button at the top of the page
            options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
            {
                Name = "Authorization",
                Description = "Enter the Bearer Authorization string as following: `Bearer Generated-JWT-Token`",
                In = ParameterLocation.Header,
                Type = SecuritySchemeType.Http,
                Scheme = "Bearer"
            });

            // AddSecurityRequirement extension method will add an authorization header to each endpoint when the request is sent
            options.AddSecurityRequirement(new OpenApiSecurityRequirement
            {
                {
                    new OpenApiSecurityScheme
                    {
                        Name = "Bearer",
                        In = ParameterLocation.Header,
                        Reference = new OpenApiReference
                        {
                            Id = "Bearer",
                            Type = ReferenceType.SecurityScheme
                        }
                    },
                    new List<string>()

                }
            });

            options.ParameterFilter<RolesParameterFilter>();
        }).AddSwaggerGenNewtonsoftSupport();
    }
}
