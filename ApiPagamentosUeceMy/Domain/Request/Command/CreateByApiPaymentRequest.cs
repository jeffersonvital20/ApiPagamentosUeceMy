using ApiPagamentosUeceMy.Domain.Model;
using ApiPagamentoUeceMy.Domain.Validation;
using MediatR;
using OperationResult;

namespace ApiPagamentosUeceMy.Domain.Request.Command
{
    public class CreateByApiPaymentRequest : IRequest<Result<bool>>, IValidatable
    {
        public Payment _pagamento { get; set; }

        public CreateByApiPaymentRequest(Payment payment)
        {
            _pagamento = payment;
        }
    }
}
