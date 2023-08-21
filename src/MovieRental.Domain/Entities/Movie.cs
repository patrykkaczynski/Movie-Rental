
namespace MovieRental.Domain.Entities;

public class Movie
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public string? Title { get; set; }
    public string? Description { get; set; }
    public string? Genre { get; set; }
    public int RunTimeMin { get; set; }
    public string? RegionOfOrigin { get; set; }
    public DateOnly? ReleaseDate { get; set; }

    //public Guid PhysicalMovieId { get; set; }
    //public PhysicalMovie? PhysicalMovie { get; set; }
    public List<Review>? Reviews { get; set; }
}
