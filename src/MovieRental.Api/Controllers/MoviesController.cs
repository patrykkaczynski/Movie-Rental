using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MovieRental.Api.Controllers.Base;
using MovieRental.Application.Features.Movies.Commands.CreateMovie;
using MovieRental.Application.Features.Movies.Commands.DeleteMovie;
using MovieRental.Application.Features.Movies.Commands.UpdateMovie;
using MovieRental.Application.Features.Movies.Queries.GetMovieDetail;
using MovieRental.Application.Features.Movies.Queries.GetMovieList;

namespace MovieRental.Api.Controllers;

[Authorize]
public class MoviesController : ApiControllerBase
{
    public MoviesController(IMediator mediator) : base(mediator) { }


    [HttpGet]
    public async Task<ActionResult<IEnumerable<MovieListQueryDto>>> GetAllMoviesAsync()
    {
        var moviesDto = await _mediator.Send(new GetMovieListQuery());

        return Ok(moviesDto);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<MovieDetailQueryDto>> GetMovieAsync([FromRoute] Guid id)
    {
        var movieDto = await _mediator.Send(new GetMovieDetailQuery(id));

        return Ok(movieDto);
    }

    [HttpPost]
    public async Task<ActionResult<int>> CreateMovieAsync([FromBody] CreateMovieCommand command)
    {
        var id = await _mediator.Send(command);
        return Created($"api/movie/{id}", null);
    }

    [HttpPut]
    public async Task<ActionResult> UpdateMovieAsync([FromBody] UpdateMovieCommand command)
    {
        await _mediator.Send(command);
        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> DeleteMovieAsync([FromRoute] Guid id)
    {
        await _mediator.Send(new DeleteMovieCommand(id));
        return NoContent();
    }

}
