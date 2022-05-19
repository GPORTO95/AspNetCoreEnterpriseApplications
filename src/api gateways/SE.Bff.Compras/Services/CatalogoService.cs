using Microsoft.Extensions.Options;
using SE.Bff.Compras.Extensions;

namespace SE.Bff.Compras.Services
{
    public interface ICatalogoService
    {

    }

    public class CatalogoService: Service, ICatalogoService
    {
        private readonly HttpClient _httpClient;

        public CatalogoService(HttpClient httpClient, IOptions<AppServicesSettings> settings)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri(settings.Value.CatalogoUrl);
        }
    }
}
