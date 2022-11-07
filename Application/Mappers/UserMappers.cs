using UserManagement.Application.DTOs;
using UserManagement.Domain.Entities;

namespace UserManagement.Application.Mappers
{
    public static class UserMappers
    {
        public static UserDTO? ToDTO(this User? user)
        {
            return user == null
                ? null
                : new UserDTO
                {
                    Id = user.Id,
                    Name = user.Name,
                    RoleIds = user.RoleIds,
                };
        }

        public static User ToDomain(this UserDTO user)
        {
            return new User
            {
                Id = user.Id,
                Name = user.Name,
                RoleIds = user.RoleIds,
            };
        }

        public static IEnumerable<UserDTO?> ToDTO(this IEnumerable<User?> users)
        {
            return users.Where(user => user != null).Select(user => user.ToDTO());
        }

        public static IEnumerable<User> ToDomain(this IEnumerable<UserDTO> users)
        {
            return users.Where(user => user != null).Select(user => user.ToDomain());
        }
    }
}
