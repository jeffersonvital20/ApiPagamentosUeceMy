using ApiPagamentosUeceMy.Domain.Model;
using ApiPagamentosUeceMy.Services.Interfaces;
using System.Text.Json;

namespace ApiPagamentosUeceMy.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IConfiguration _configuration;

        public UsuarioService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task SendPagamentoAsync(Payment payment)
        {
            HttpClient httpClient = new HttpClient();
            string data = JsonSerializer.Serialize(payment);
            var content = new StringContent(data);
            string uri = $"http://localhost:5198/api/Usuario/AtualizaCurso?IdUsuario={payment.IdUsuario}&IdCurso={payment.IdCurso}&pago=true";//_configuration["streamService"] + "api/Streams/create";
            var response = await httpClient.PostAsync(uri, content);

            var result = await response.Content.ReadAsStringAsync();
            var obj = JsonSerializer.Deserialize<bool>(result);

        }
    }
}
