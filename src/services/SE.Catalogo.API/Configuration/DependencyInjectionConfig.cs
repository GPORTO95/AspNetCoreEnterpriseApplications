using SE.Catalogo.API.Data;
using SE.Catalogo.API.Data.Repository;
using SE.Catalogo.API.Models;

namespace SE.Catalogo.API.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void AddDIConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<CatalogoContext>();
        }
    }
}
