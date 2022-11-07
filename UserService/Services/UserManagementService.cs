using Grpc.Core;
using MediatR;
using UserManagement.Application.Mediatr.Commands.UserManagement.CreateUser;
using UserManagement.Application.Mediatr.Queries.UserManagement.GetAllUsers;
using UserManagement.Application.Mediatr.Queries.UserManagement.GetUser;
using UserManagement.UserService.Mappers.UserManagement;
using UserManagement.UserService.Protos;

namespace UserManagement.UserService.Services
{
    public class UserManagementService : UsersManagement.UsersManagementBase
    {
        private readonly ILogger<UserManagementService> _logger;
        private readonly IMediator _mediator;

        public UserManagementService(ILogger<UserManagementService> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        public override async Task<GetUserResponse> GetUser(GetUserRequest request, ServerCallContext context)
        {
            var result = await _mediator.Send(new GetUserQuery
            {
                Id = request.UserId
            });

            return result.ToResponse();
        }

        public override async Task<GetAllUsersResponse> GetAllUsers(Empty request, ServerCallContext context)
        {
            var result = await _mediator.Send(new GetAllUsersQuery());

            return result.ToResponse();
        }

        public override async Task<CreateUserResponse> CreateUser(CreateUserRequest request, ServerCallContext context)
        {
            var result = await _mediator.Send(new CreateUserCommand
            {
                Id = request.UserId,
                Name = request.UserName,
                RoleIds = request.UserRoleIds.ToArray()
            });

            return result.ToResponse();
        }
    }
}