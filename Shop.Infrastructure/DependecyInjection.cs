using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Shop.Application.Abstractions;
using Shop.Infrastructure.Persistance;

namespace Shop.Infrastructure
{
    public static class DependecyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<IApplicationDbContext,ShopDbContext>(ops =>
            ops
                .UseLazyLoadingProxies()
                    .UseNpgsql(configuration.GetConnectionString("con")));
            return services;
        }
    }
}
