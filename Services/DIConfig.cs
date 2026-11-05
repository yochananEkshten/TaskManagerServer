using Microsoft.Extensions.DependencyInjection;
using Services.Interfaces;
using Repository;


namespace Services
{
    public static class DIConfig
    {
        public static void ConfigureServices(this IServiceCollection services)
        {
            services.AddScoped<ITaskService, TaskService>();

            services.ConfigureRepositoryServices();
        }
    }
}

