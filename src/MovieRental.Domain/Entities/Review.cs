
namespace MovieRental.Domain.Entities;

public class Review
{
    public Guid Id { get; private set; }
    public required string Description { get; set; }
    public int Rating { get; set; }
    public required string CreatedBy { get; set; }
    public DateTime CreationDate { get; set; }

    public Guid MovieId { get; set; }
    public Movie? Movie { get; set; }
}
