using UserManagement.Application.Implementations;
using UserManagement.Application.Interfaces;
using MediatR;
using System.Reflection;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ConfigureApplicationServices
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddTransient<IUserManager, UserManager>();
            services.AddMediatR(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}