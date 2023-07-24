using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using MovieRental.Domain.Interfaces;
using MovieRental.Infrastructure.Authentication;
using MovieRental.Infrastructure.Persistence;
using MovieRental.Infrastructure.Repositories;
using MovieRental.Infrastructure.Settings;
using System.Text;

namespace MovieRental.Infrastructure.Extensions;

public static class ServiceCollectionExtension
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {

        //Authentication Settings
        var authenticationSettings = new AuthenticationSettings();
        configuration.GetSection("Authentication").Bind(authenticationSettings);

        services.AddSingleton(authenticationSettings);

        services.AddAuthentication(option =>
        {
            option.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            option.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            option.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
        }).AddJwtBearer(cfg =>
        {
            cfg.RequireHttpsMetadata = false;
            cfg.SaveToken = true;
            cfg.TokenValidationParameters = new TokenValidationParameters
            {
                ValidIssuer = authenticationSettings.JwtIssuer, 
                ValidAudience = authenticationSettings.JwtIssuer, 
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(authenticationSettings.JwtKey)),
            };
        });
 
        //DbContext - PostgreSQL
        services.AddDbContext<MovieRentalDbContext>(options =>
            options.UseNpgsql(configuration.GetConnectionString("MovieRental")));

        //Repositories
        services.AddScoped<IMovieRepository, MovieRepository>();
        services.AddScoped<IAccountRepository, AccountRepository>();
        services.AddScoped<IReviewRepository, ReviewRepository>();

        //JwtProvider
        services.AddScoped<IJwtProvider, JwtProvider>();

        return services;
    }
}
