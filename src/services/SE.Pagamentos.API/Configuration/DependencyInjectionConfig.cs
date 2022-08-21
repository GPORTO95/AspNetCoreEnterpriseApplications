using SE.Pagamentos.API.Data;
using SE.Pagamentos.API.Data.Repository;
using SE.Pagamentos.API.Facade;
using SE.Pagamentos.API.Models;
using SE.Pagamentos.API.Services;
using SE.WebApi.Core.Usuario;

namespace SE.Pagamentos.API.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<IAspNetUser, AspNetUser>();

            services.AddScoped<IPagamentoService, PagamentoService>();
            services.AddScoped<IPagamentoFacade, PagamentoCartaoCreditoFacade>();

            services.AddScoped<IPagamentoRepository, PagamentoRepository>();
            services.AddScoped<PagamentosContext>();
        }
    }
}
