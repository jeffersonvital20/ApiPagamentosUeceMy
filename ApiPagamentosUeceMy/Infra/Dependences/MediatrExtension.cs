using ApiPagamentosUeceMy.Domain.Request.Command;

namespace ApiPagamentosUeceMy.Dependences;

public static class MediatrExtension
{
    public static void AddMediatRApi(this IServiceCollection services)
    {
        //services.AddMediatR(typeof(CreateMembroRequest).Assembly);
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof(CreatePaymentRequest).Assembly));
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof(CreateByApiPaymentRequest).Assembly));
        //services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof(AutorizarUsuarioRequest).Assembly));
        //services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof(UpdateMembroRequest).Assembly));
        //services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof(UsuarioGetByIdQuery).Assembly));
    }
}
