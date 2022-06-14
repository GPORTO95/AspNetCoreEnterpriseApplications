using Microsoft.Extensions.Options;
using SE.Core.Comunication;
using SE.WebApp.MVC.Extensions;
using SE.WebApp.MVC.Models;
using System.Net;

namespace SE.WebApp.MVC.Services
{
    public interface IClienteService
    {
        Task<EnderecoViewModel> ObterEndereco();

        Task<ResponseResult> AdicionarEndereco(EnderecoViewModel endereco);
    }

    public class ClienteService : Service, IClienteService
    {
        private readonly HttpClient _httpClient;

        public ClienteService(HttpClient httpClient, IOptions<AppSettings> settings)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri(settings.Value.ClienteUrl);
        }

        public async Task<EnderecoViewModel> ObterEndereco()
        {
            var response = await _httpClient.GetAsync("/cliente/endereco/");

            if (response.StatusCode == HttpStatusCode.NotFound) return null;

            TratarErrosResponse(response);

            return await DeserializarObjetoResponse<EnderecoViewModel>(response);
        }

        public async Task<ResponseResult> AdicionarEndereco(EnderecoViewModel endereco)
        {
            var enderecoContent = ObterConteudo(endereco);

            var response = await _httpClient.PostAsync("/cliente/endereco/", enderecoContent);

            if(!TratarErrosResponse(response)) return await DeserializarObjetoResponse<ResponseResult>(response);

            return RetornoOk();
        }
    }
}
