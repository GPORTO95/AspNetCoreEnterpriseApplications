using Microsoft.Extensions.Options;
using SE.Bff.Compras.Extensions;

namespace SE.Bff.Compras.Services
{
    public interface IPedidoService
    {

    }

    public class PedidoService : Service, IPedidoService
    {
        private readonly HttpClient _httpClient;

        public PedidoService(HttpClient httpClient, IOptions<AppServicesSettings> settings)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri(settings.Value.PedidoUrl);
        }
    }
}
