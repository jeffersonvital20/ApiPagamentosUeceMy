using ApiPagamentosUeceMy.Domain.Request.Command;
using ApiPagamentosUeceMy.Services.Interfaces;
using MediatR;
using OperationResult;

namespace ApiPagamentosUeceMy.Domain.RequestHandlers.CommandHandler
{
    public class CreateByApiPaymentRequestHandler : IRequestHandler<CreateByApiPaymentRequest, Result<bool>>
    {
        private readonly IUsuarioService _service;

        public CreateByApiPaymentRequestHandler(IUsuarioService usuarioService)
        {
            _service = usuarioService;
        }
        public Task<Result<bool>> Handle(CreateByApiPaymentRequest request, CancellationToken cancellationToken)
        {
            _service.SendPagamentoAsync(request._pagamento);
            return Result.Success(true);
        }
    }
}
