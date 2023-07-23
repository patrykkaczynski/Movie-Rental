using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MovieRental.Domain.Interfaces;
using MovieRental.Infrastructure.Persistence;
using MovieRental.Infrastructure.Repositories;

namespace MovieRental.Infrastructure.Extensions;

public static class ServiceCollectionExtension
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
 
        services.AddDbContext<MovieRentalDbContext>(options =>
            options.UseNpgsql(configuration.GetConnectionString("MovieRental")));

        services.AddScoped<IMovieRepository, MovieRepository>();

        return services;
    }
}
