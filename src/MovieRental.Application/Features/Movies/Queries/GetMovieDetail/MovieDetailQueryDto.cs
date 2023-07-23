namespace MovieRental.Application.Features.Movies.Queries.GetMovieDetail;

public class MovieDetailQueryDto
{
    public Guid Id { get; private set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public string? Genre { get; set; }
    public int RunTimeMin { get; set; }
    public string? RegionOfOrigin { get; set; }
    public DateOnly? ReleaseDate { get; set; }
}
