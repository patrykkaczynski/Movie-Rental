

namespace MovieRental.Application.Features.Reviews.Queries;

public class GetReviewListQueryDto
{
    public Guid Id { get; private set; }
    public string? Description { get; set; }
    public int Rating { get; set; }
    public string? CreatedBy { get; set; }
    public DateTime CreationDate { get; set; }
}
