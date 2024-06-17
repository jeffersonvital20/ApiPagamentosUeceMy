using ApiPagamentosUeceMy.Domain.Model;

namespace ApiPagamentosUeceMy.Services.Interfaces
{
    public interface IUsuarioService
    {
        Task SendPagamentoAsync(Payment payment);
    }
}
