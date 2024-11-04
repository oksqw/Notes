using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Notes.WebApi.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class Controller : ControllerBase
{
    private IMediator? _mediator;
    protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>() ?? throw new NullReferenceException($"{nameof(IMediator)} is null");
}