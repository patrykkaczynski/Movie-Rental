using Microsoft.AspNetCore.Mvc;

namespace MovieRental.Application.Features.Reviews.Commands;

public record ReviewDto
{
    public string? Description { get; set; }
    public int Rating { get; set; }
}
