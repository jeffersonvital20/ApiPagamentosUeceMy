using ApiPagamentosUeceMy.Domain.Interfaces;
using ApiPagamentosUeceMy.Domain.Model;
using RabbitMQ.Client;
using System.Text;
using System.Text.Json;

namespace ApiPagamentosUeceMy.Infra.Repositories;

public class RabbitMenssagemRepository : IRabbitMenssagemRepository
{
    public void SendMensagem(Payment payment)
    {
        var factory = new ConnectionFactory 
        { 
            HostName = "localhost" ,
            UserName = "admin" ,
            Password = "123456" ,
        };
        using var connection = factory.CreateConnection();
        using var channel = connection.CreateModel();

        channel.QueueDeclare(queue: "FilaPagamento",
                             durable: false,
                             exclusive: false,
                             autoDelete: false,
                             arguments: null);

        string json = JsonSerializer.Serialize(payment);
        var body = Encoding.UTF8.GetBytes(json);

        channel.BasicPublish(exchange: string.Empty,
                             routingKey: "FilaPagamento",
                             basicProperties: null,
                             body: body);
        
    }
}
