using UserManagement.Application.DTOs;
using UserManagement.UserService.Protos;

namespace UserManagement.UserService.Mappers.UserManagement
{
    public static class UserResponseMappers
    {
        #region GET
        public static GetUserResponse ToResponse(this UserDTO? user)
        {
            if (user == null)
            {
                return new GetUserResponse();
            }

            var response = new GetUserResponse
            {
                UserId = user.Id,
                UserName = user.Name
            };
            response.UserRoleIds.Add(user.RoleIds);

            return response;
        }

        public static GetAllUsersResponse ToResponse(this IEnumerable<UserDTO> usersToMap)
        {
            var users = usersToMap.Select(userToMap => new GetUserResponse { UserId = userToMap.Id, UserName = userToMap.Name });
            var response = new GetAllUsersResponse();
            response.Users.Add(users);
            return response;
        }
        #endregion

        #region CREATE
        public static CreateUserResponse ToResponse(this int userId)
        {
            return new CreateUserResponse { UserId = userId };
        }
        #endregion
    }
}
