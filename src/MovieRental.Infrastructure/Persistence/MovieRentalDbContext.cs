using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MovieRental.Domain.Entities;

namespace MovieRental.Infrastructure.Persistence;

public class MovieRentalDbContext : DbContext
{
    public MovieRentalDbContext(DbContextOptions options) : base(options)
    {
    }
    public DbSet<CountryOfOrigin> CountriesOfOrigin { get; set; }
    public DbSet<Format> Formats { get; set; }
    public DbSet<Genre> Genres { get; set; }
    public DbSet<Movie> Movies { get; set; }
    public DbSet<PhysicalMovie> PhysicalMovies { get; set; }
    public DbSet<Rental> Rentals { get; set; }
    public DbSet<Review> Reviews { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
    }
}
