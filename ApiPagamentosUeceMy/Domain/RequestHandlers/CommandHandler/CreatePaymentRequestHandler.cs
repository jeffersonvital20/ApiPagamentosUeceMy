using ApiPagamentosUeceMy.Domain.Interfaces;
using ApiPagamentosUeceMy.Domain.Model;
using ApiPagamentosUeceMy.Domain.Request;
using ApiPagamentosUeceMy.Domain.Request.Command;
using ApiPagamentosUeceMy.Services.Interfaces;
using MediatR;
using OperationResult;

namespace ApiPagamentosUeceMy.Domain.RequestHandlers.CommandHandler;

public class CreatePaymentRequestHandler : IRequestHandler<CreatePaymentRequest, Result<bool>>
{
    private readonly IRabbitServices _rabbitServices;

    public CreatePaymentRequestHandler(IRabbitServices rabbitServices)
    {
        _rabbitServices = rabbitServices;
    }
    public Task<Result<bool>> Handle(CreatePaymentRequest request, CancellationToken cancellationToken)
    {
        if (request == null) throw new ArgumentNullException(nameof(request));
        if (request._pagamento.pago)
        {
            _rabbitServices.SendMensagem(request._pagamento);
        }
        return Result.Success(true);
    }
}
