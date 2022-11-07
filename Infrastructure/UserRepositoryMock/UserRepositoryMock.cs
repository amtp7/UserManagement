using UserManagement.Application.Interfaces;
using UserManagement.Domain.Entities;

namespace UserManagement.Infrastructure.UserRepositoryMock
{
    public class UserRepositoryMock : IUserRepositoryMock
    {
        private static List<User> users;

        public UserRepositoryMock()
        {
            users = new List<User>
            {
                new User { Id = 1, Name = "António", RoleIds = new int[] { 1 } },
                new User { Id = 2, Name = "Sara", RoleIds = new int[] { 1, 2 } },
                new User { Id = 3, Name = "Bárbara", RoleIds = new int[] { 1, 3 } },
                new User { Id = 4, Name = "David", RoleIds = new int[] { 2, 4 } }
            };
        }

        public async Task<User?> GetUser(int id)
        {
            return await Task.FromResult(users.SingleOrDefault(user => user.Id == id));
        }

        public async Task<List<User>> GetAllUsers()
        {
            return await Task.FromResult(users);
        }

        public async Task CreateUser(User user)
        {
            users.Add(user);
            await Task.CompletedTask;
        }
    }
}
