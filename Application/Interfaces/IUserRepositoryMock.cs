using UserManagement.Domain.Entities;

namespace UserManagement.Application.Interfaces
{
    public interface IUserRepositoryMock
    {
        public Task<User?> GetUser(int id);
        public Task<List<User>> GetAllUsers();
        public Task<int> CreateUser(User user);
    }
}
