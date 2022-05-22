using SE.Bff.Compras.Extensions;
using SE.WebApi.Core.Identidade;

namespace SE.Bff.Compras.Configuration
{
    public static class ApiConfig
    {
        public static void AddApiConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddControllers();

            services.Configure<AppServicesSettings>(configuration);

            services.AddCors(options => {
                options.AddPolicy("total",
                builder =>
                    builder
                    .AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    );
            });
        }

        public static void UseApiConfiguration(this WebApplication app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors("total");

            app.UseAuthConfiguration();

            app.MapControllers();
        }
    }
}
