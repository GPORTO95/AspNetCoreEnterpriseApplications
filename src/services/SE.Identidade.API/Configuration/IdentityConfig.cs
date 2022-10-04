using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SE.Identidade.API.Data;
using SE.Identidade.API.Extensions;
using SE.WebApi.Core.Identidade;

namespace SE.Identidade.API.Configuration
{
    public static class IdentityConfig
    {
        public static IServiceCollection AddIdentityConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            services
                .AddJwksManager()
                .PersistKeysToDatabaseStore<ApplicationDbContext>();

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            services.AddDefaultIdentity<IdentityUser>()
                .AddRoles<IdentityRole>()
                .AddErrorDescriber<IdentityMensagensPortugues>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            // JWT
            services.AddJwtConfiguration(configuration);

            return services;
        }
    }
}
