using MediatR;
using Microsoft.AspNetCore.Mvc;
using MovieRental.Api.Controllers.Base;
using MovieRental.Application.Features.CountriesOfOrigin.Queries.GetCountryOfOriginList;

namespace MovieRental.Api.Controllers;

[Route("api/countriesOfOrigin")]
[ApiController]
public class CountryOfOriginController : ApiControllerBase
{
    public CountryOfOriginController(IMediator mediator) : base(mediator) { }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<CountryOfOriginListQueryDto>>> GetAllCountriesOfOrigin(CancellationToken cancellationToken)
    {
        var countriesOfOriginDto = await _mediator.Send(new GetCountryOfOriginListQuery(), cancellationToken);

        return Ok(countriesOfOriginDto);
    }
}
