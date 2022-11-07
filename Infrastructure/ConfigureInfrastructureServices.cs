using UserManagement.Application.Interfaces;
using UserManagement.Infrastructure.UserRepositoryMock;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ConfigureInfrastructureServices
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddSingleton<IUserRepositoryMock, UserRepositoryMock>();

            return services;
        }
    }
}