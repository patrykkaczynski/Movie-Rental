using MediatR;
using Microsoft.AspNetCore.Mvc;
using MovieRental.Api.Controllers.Base;
using MovieRental.Application.Features.Genres.Queries.GetGenreList;

namespace MovieRental.Api.Controllers;

[Route("api/genres")]
[ApiController]
public class GenreController : ApiControllerBase
{
    public GenreController(IMediator mediator) : base(mediator) { }

    [HttpGet]
    public async Task<ActionResult<GenreListQueryDto>> GetAllGenres(CancellationToken cancellationToken)
    {
        var genresDto = await _mediator.Send(new GetGenreListQuery(), cancellationToken);

        return Ok(genresDto);
    }
}
