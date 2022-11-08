using GrpcClient;
using UserManagement.Application.Interfaces;

namespace UserManagement.Infrastructure.AuthorizationClient
{
    public class AuthorizationClient : IAuthorizationClient
    {
        private readonly Client _client;
        public AuthorizationClient(Client client)
        {
            _client = client;
        }

        public async Task<string> GetRolesAuthorization(int[] roleIds)
        {
            return (await _client.AuthorizeRolesAsync(roleIds)).AuthorizationStatus;
        }
    }
}
