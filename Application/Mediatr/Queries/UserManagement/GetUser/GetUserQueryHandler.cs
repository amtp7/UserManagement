using UserManagement.Application.DTOs;
using UserManagement.Application.Interfaces;
using MediatR;

namespace UserManagement.Application.Mediatr.Queries.UserManagement.GetUser
{
    public class GetUserQueryHandler : IRequestHandler<GetUserQuery, UserDTO?>
    {
        private readonly IUserManager _userManager;

        public GetUserQueryHandler(IUserManager userManager)
        {
            _userManager = userManager;
        }

        public async Task<UserDTO?> Handle(GetUserQuery request, CancellationToken cancellationToken)
        {
            return await _userManager.GetUser(request.Id);
        }
    }
}
