
namespace MovieRental.Application.Features.Reviews.Commands;

public record CreateReviewDto(
    string? Description, 
    int Rating);
