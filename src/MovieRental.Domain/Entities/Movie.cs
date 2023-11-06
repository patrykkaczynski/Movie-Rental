
namespace MovieRental.Domain.Entities;

public class Movie
{
    public int Id { get; private set; }
    public required string Title { get; set; }
    public required string Description { get; set; }
    public required string Genre { get; set; }
    public int RunTimeMin { get; set; }
    public required string RegionOfOrigin { get; set; }
    public DateOnly ReleaseDate { get; set; }

    public ICollection<PhysicalMovie> PhysicalMovies { get; set; } = new List<PhysicalMovie>();
    public ICollection<Review> Reviews { get; set; } = new List<Review>();
}
