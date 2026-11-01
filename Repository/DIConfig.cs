using Microsoft.Extensions.DependencyInjection;
using Model;
using Repository.Interfaces;


namespace Repository
{
    public static class DIConfig
    {
        public static void ConfigureRepositoryServices(this IServiceCollection services)
        {
            services.AddScoped<ITaskRepository, TaskRepository>();
            services.AddDbContextFactory<TaskManagerContext>(lifetime: ServiceLifetime.Scoped);
            services.AddAutoMapper(typeof(AutoMapperProfile));

        }
    }
}
