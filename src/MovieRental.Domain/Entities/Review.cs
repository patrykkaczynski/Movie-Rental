
namespace MovieRental.Domain.Entities;

public class Review
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public string? Description { get; set; }
    public int Rating { get; set; }
    public string? CreatedBy { get; set; }
    public DateTime CreationDate { get; set; }

    public Guid MovieId { get; set; }
    public Movie? Movie { get; set; }
}
