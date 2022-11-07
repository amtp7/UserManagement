using UserManagement.Application.DTOs;

namespace UserManagement.Application.Interfaces
{
    public interface IUserManager
    {
        public Task<int> CreateUser(UserDTO user);
        public Task<IEnumerable<UserDTO?>> GetAllUsers();
        public Task<UserDTO?> GetUser(int id);
    }
}
