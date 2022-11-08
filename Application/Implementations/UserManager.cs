using UserManagement.Application.DTOs;
using UserManagement.Application.Interfaces;
using UserManagement.Application.Mappers;

namespace UserManagement.Application.Implementations
{
    public class UserManager : IUserManager
    {
        private readonly IUserRepositoryMock _userRepositoryMock;
        private readonly IAuthorizationClient _authorizationClient;

        public UserManager(IUserRepositoryMock userRepositoryMock, IAuthorizationClient authorizationClient)
        {
            _userRepositoryMock = userRepositoryMock;
            _authorizationClient = authorizationClient;
        }

        public async Task<int> CreateUser(UserDTO newUser)
        {
            var user = _userRepositoryMock.GetUser(newUser.Id).Result;

            if (user == null)
            {
                var authorization = await _authorizationClient.GetRolesAuthorization(newUser.RoleIds);
                if (authorization == "Authorized")
                {
                    return await _userRepositoryMock.CreateUser(newUser.ToDomain());                  
                }             
            }
            return -1;
        }

        public async Task<IEnumerable<UserDTO?>> GetAllUsers()
        {
            var result = await _userRepositoryMock.GetAllUsers();
            return result.ToDTO();
        }

        public async Task<UserDTO?> GetUser(int id)
        {
            var result = await _userRepositoryMock.GetUser(id);
            return result.ToDTO();
        }
    }
}