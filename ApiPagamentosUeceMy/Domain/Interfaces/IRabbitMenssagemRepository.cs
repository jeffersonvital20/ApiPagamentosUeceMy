using ApiPagamentosUeceMy.Domain.Model;

namespace ApiPagamentosUeceMy.Domain.Interfaces;

public interface IRabbitMenssagemRepository
{
    void SendMensagem(Payment payment);
}
