using Microsoft.EntityFrameworkCore;
using SE.Carrinho.API.Data;
using SE.WebApi.Core.Identidade;

namespace SE.Carrinho.API.Configuration
{
    public static class ApiConfig
    {
        public static void AddApiConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<CarrinhoContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            services.AddControllers();

            services.AddCors(options =>
            {
                options.AddPolicy("Total",
                    builder =>
                        builder.AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader());
            });
        }

        public static void UseApiConfiguration(this WebApplication app)
        {
            if (app.Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors("Total");

            app.UseAuthConfiguration();

            app.MapControllers();
        }
    }
}
