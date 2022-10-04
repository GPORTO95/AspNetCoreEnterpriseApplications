using SE.WebApi.Core.Identidade;
using SE.WebApi.Core.Usuario;

namespace SE.Identidade.API.Configuration
{
    public static class ApiConfig
    {
        public static IServiceCollection AddApiConfiguration(this IServiceCollection services)
        {
            services.AddControllers();

            services.AddScoped<IAspNetUser, AspNetUser>();

            return services;
        }

        public static WebApplication UseApiConfiguration(this WebApplication app, IWebHostEnvironment environment)
        {
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseAuthConfiguration();

            app.MapControllers();

            //localhost/jwks
            app.UseJwksDiscovery();

            return app;
        }
    }
}
