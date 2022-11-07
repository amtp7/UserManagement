using MediatR;

namespace UserManagement.Application.Mediatr.Commands.UserManagement.CreateUser
{
    public record CreateUserCommand : IRequest<int>
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int[] RoleIds { get; set; }
    }
}
