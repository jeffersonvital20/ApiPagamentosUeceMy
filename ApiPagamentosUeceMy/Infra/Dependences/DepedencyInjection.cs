using ApiPagamentosUeceMy.Domain.Interfaces;
using ApiPagamentosUeceMy.Infra.Repositories;
using ApiPagamentosUeceMy.Services;
using ApiPagamentosUeceMy.Services.Interfaces;

namespace ApiPagamentosUeceMy.Dependences;

public static class DepedencyInjection
{
    public static void AddDepencies(this IServiceCollection services)
    {
        AddRepositoryDependency(services);
    }

    private static void AddRepositoryDependency(IServiceCollection services)
    {
        services.AddScoped<IRabbitServices, RabbitServices>();
        services.AddScoped<IRabbitMenssagemRepository, RabbitMenssagemRepository>();
        services.AddScoped<IUsuarioService, UsuarioService>();
    }
}
