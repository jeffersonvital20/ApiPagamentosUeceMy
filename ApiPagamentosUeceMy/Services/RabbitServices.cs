using ApiPagamentosUeceMy.Domain.Interfaces;
using ApiPagamentosUeceMy.Domain.Model;
using ApiPagamentosUeceMy.Services.Interfaces;

namespace ApiPagamentosUeceMy.Services;

public class RabbitServices : IRabbitServices
{
    private readonly IRabbitMenssagemRepository _repository;

    public RabbitServices(IRabbitMenssagemRepository rabbitMenssagemRepository)
    {
        _repository = rabbitMenssagemRepository;
    }

    public void SendMensagem(Payment payment)
    {
        _repository.SendMensagem(payment);
    }
}
