
namespace MovieRental.Domain.Entities;

public class Response
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public string? Description { get; set; }
    public string? CreatedBy { get; set; }
    public DateTime CreationDate { get; set; }
    public int NumberOfLikes { get; set; } = 0;
    public int NumberOfDislikes { get; set; } = 0;

    public Guid ReviewId { get; set; }
    public Review? Review { get; set; }

}
