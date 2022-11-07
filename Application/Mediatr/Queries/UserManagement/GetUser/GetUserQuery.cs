using UserManagement.Application.DTOs;
using MediatR;

namespace UserManagement.Application.Mediatr.Queries.UserManagement.GetUser
{
    public record GetUserQuery : IRequest<UserDTO?>
    {
        public int Id { get; set; }
    }
}
