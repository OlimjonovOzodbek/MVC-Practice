using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Shop.Application
{
    public static class Dependecy
    {
        public static IServiceCollection DependAdd(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
