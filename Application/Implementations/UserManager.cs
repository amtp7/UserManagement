using UserManagement.Application.DTOs;
using UserManagement.Application.Interfaces;
using UserManagement.Application.Mappers;

namespace UserManagement.Application.Implementations
{
    public class UserManager : IUserManager
    {
        private readonly IUserRepositoryMock _userRepositoryMock;

        public UserManager(IUserRepositoryMock userRepositoryMock)
        {
            _userRepositoryMock = userRepositoryMock;
        }

        public async Task<int> CreateUser(UserDTO newUser)
        {
            var users = _userRepositoryMock.GetAllUsers().Result;

            if (newUser != null && users.SingleOrDefault(user => user.Id == newUser.Id || user.Name == newUser.Name) == null)
            {
                await _userRepositoryMock.CreateUser(newUser.ToDomain());
            }
            return (await _userRepositoryMock.GetUser(newUser.Id)).Id;
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