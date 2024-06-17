using ApiPagamentosUeceMy.Domain.Execption;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using OperationResult;

namespace ApiPagamentosUeceMy.Controllers.Base;

[ApiController]
[Route("api/[controller]")]
public class BaseController : ControllerBase
{
    private readonly IMediator _mediator;

    protected BaseController(IMediator mediator) => _mediator = mediator;

    protected async Task<IActionResult> SendRequest<T>(IRequest<Result<T>> request)
        => await _mediator.Send(request).ConfigureAwait(false) switch
        {
            (true, var result, _) => Ok(result),
            //(_, _, var error) => BadRequest(new Result(error))
            (_, _, var error) => HandleError(error)
        };

    protected async Task<IActionResult> SendRequest(IRequest<Result> request, int statusCode = 200)
        => await _mediator.Send(request).ConfigureAwait(false) switch
        {
            (true, _) => Ok(statusCode),
            (_, var error) => HandleError(error)
        };

    private IActionResult HandleError(Exception error)
        => error switch
        {
            AppPagamentoUceMyValidatorException exception => BadRequest(exception.Errors),
            _ => BadRequest(new Result(error))
        };
}
