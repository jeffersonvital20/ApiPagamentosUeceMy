using ApiPagamentosUeceMy.Controllers.Base;
using ApiPagamentosUeceMy.Domain.Model;
using ApiPagamentosUeceMy.Domain.Request.Command;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ApiPagamentosUeceMy.Controllers
{
    public class PagamentoController : BaseController
    {
        public PagamentoController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost("create")]
        public Task<IActionResult> Create([FromBody] Payment payment)
           => SendRequest(new CreatePaymentRequest(payment));
        
        [HttpPost("createByApi")]
        public Task<IActionResult> CreateByApi([FromBody] Payment payment)
           => SendRequest(new CreateByApiPaymentRequest(payment));
    }
}
