using UserManagement.Application.DTOs;
using MediatR;

namespace UserManagement.Application.Mediatr.Queries.UserManagement.GetAllUsers
{
    public record GetAllUsersQuery : IRequest<IEnumerable<UserDTO>>
    {
    }
}
