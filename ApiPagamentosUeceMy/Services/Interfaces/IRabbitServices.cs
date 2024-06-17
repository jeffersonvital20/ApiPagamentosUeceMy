using ApiPagamentosUeceMy.Domain.Model;

namespace ApiPagamentosUeceMy.Services.Interfaces;

public interface IRabbitServices
{
    void SendMensagem(Payment payment);
}
