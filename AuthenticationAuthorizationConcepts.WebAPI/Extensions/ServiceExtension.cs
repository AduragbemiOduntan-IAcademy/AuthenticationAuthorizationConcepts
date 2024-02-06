using AuthenticationAuthorizationConcepts.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace AuthenticationAuthorizationConcepts.WebAPI.Extensions
{
    public static class ServiceExtension
    {
        public static void DbConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DataBaseContext>(option =>
            {
                option.UseSqlServer(configuration.GetConnectionString("SqlConnection"));
            });
        }

    }
}
