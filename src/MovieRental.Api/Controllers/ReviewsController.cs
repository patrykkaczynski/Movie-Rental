using MediatR;
using Microsoft.AspNetCore.Mvc;
using MovieRental.Api.Controllers.Base;
using MovieRental.Application.Features.Reviews.Commands;
using MovieRental.Application.Features.Reviews.Queries;

namespace MovieRental.Api.Controllers;

[Route("api/movies/{movieId}/reviews")]
[ApiController]
public class ReviewsController : ApiControllerBase
{
    public ReviewsController(IMediator mediator) : base(mediator) { }

    [HttpGet]
    public async Task<ActionResult> GetReviewsAsync([FromRoute] Guid movieId)
    {
        var reviews = await _mediator.Send(new GetReviewsQuery(movieId));
        return Ok(reviews);
    }

    [HttpPost]
    public async Task<ActionResult> CreateReviewAsync([FromRoute] Guid movieId, [FromBody] ReviewDto reviewDto)
    {
        var id = await _mediator.Send(new CreateReviewCommand(movieId, reviewDto.Description, reviewDto.Rating));

        return Created($"api/movie/{movieId}/review/{id}", null);
    }



}
