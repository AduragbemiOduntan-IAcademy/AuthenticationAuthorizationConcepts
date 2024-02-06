namespace AuthenticationAuthorizationConcepts.WebAPI.Extensions
{
    public static class ServiceExtension
    {
        public static void DbConfiguration(this IServiceCollection services)
        {
            services.AddDbContext()

           /* services.AddDbContext(option =>
            {
                option.UseSqlServer(configuration.GetConnectionString("Default"),
                    optionAction => optionAction.MigrationsAssembly(typeof(T).Assembly.FullName));
            });*/
        }

    }
}
