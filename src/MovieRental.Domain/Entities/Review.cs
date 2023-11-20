
namespace MovieRental.Domain.Entities;

public class Review
{
    public int Id { get; set; }
    public required string Description { get; set; }
    public int Rating { get; set; }
    public required string CreatedBy { get; set; }
    public DateTimeOffset CreationDate { get; set; }

    public int MovieId { get; set; }
    public Movie? Movie { get; set; }
}
