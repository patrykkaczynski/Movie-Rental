using MediatR;
using Microsoft.AspNetCore.Mvc;
using MovieRental.Api.Controllers.Base;
using MovieRental.Application.Features.Accounts.Commands.LoginUser;
using MovieRental.Application.Features.Accounts.Commands.RegisterUser;

namespace MovieRental.Api.Controllers;

[Route("api/account")]
public class AccountController : ApiControllerBase
{
    public AccountController(IMediator mediator) : base(mediator) { }

    [HttpPost("register")]
    public async Task<ActionResult> RegisterUser([FromBody] RegisterUserCommand command)
    {

        await _mediator.Send(command);
        return Ok();
    }

    [HttpPost("login")]
    public async Task<ActionResult> LoginUser([FromBody] LoginUserCommand command)
    {
        var token = await _mediator.Send(command);
        return Ok(token);
    }

}