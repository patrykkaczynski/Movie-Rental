using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MovieRental.Api.Controllers.Base
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class ApiControllerBase : ControllerBase
    {
        protected readonly IMediator _mediator;

        public ApiControllerBase(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}
