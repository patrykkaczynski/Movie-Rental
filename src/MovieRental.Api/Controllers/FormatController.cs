using MediatR;
using Microsoft.AspNetCore.Mvc;
using MovieRental.Api.Controllers.Base;
using MovieRental.Application.Features.Formats.Queries.GetFormatList;

namespace MovieRental.Api.Controllers;

[Route("api/formats")]
[ApiController]
public class FormatController : ApiControllerBase
{
    public FormatController(IMediator mediator) : base(mediator) { }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<FormatListQueryDto>>> GetAllFormats(CancellationToken cancellationToken)
    {
        var formatsDto = await _mediator.Send(new GetFormatListQuery(), cancellationToken);

        return Ok(formatsDto);
    }
}
