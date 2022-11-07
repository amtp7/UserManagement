using UserManagement.Application.DTOs;
using UserManagement.Application.Interfaces;
using MediatR;

namespace UserManagement.Application.Mediatr.Queries.UserManagement.GetAllUsers
{
    public class GetAllUsersQueryHandler : IRequestHandler<GetAllUsersQuery, IEnumerable<UserDTO?>>
    {
        private readonly IUserManager _userManager;

        public GetAllUsersQueryHandler(IUserManager userManager)
        {
            _userManager = userManager;
        }

        public async Task<IEnumerable<UserDTO?>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
        {
            return await _userManager.GetAllUsers();
        }
    }
}
