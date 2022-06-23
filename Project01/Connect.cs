using Microsoft.EntityFrameworkCore;
using Project01.EF;

namespace Project01
{
    public static class Connect
    {
        public static IServiceCollection ServicesCollection(this IServiceCollection service, IConfiguration configuration)
        {
            service.AddDbContext<ProjectDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("AltaProject"),
               x => x.MigrationsAssembly(typeof(ProjectDbContext).Assembly.FullName)), ServiceLifetime.Transient);

            return service;
        }
    }
}