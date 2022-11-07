using UserManagement.Application.DTOs;
using UserManagement.Application.Interfaces;
using MediatR;

namespace UserManagement.Application.Mediatr.Commands.UserManagement.CreateUser
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, int>
    {
        private readonly IUserManager _userManager;

        public CreateUserCommandHandler(IUserManager userManager)
        {
            _userManager = userManager;
        }

        public async Task<int> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            return await _userManager.CreateUser(new UserDTO 
            { 
                Id = request.Id, 
                Name = request.Name,
                RoleIds = request.RoleIds
            });
        }
    }
}
