using UserManagement.Application.DTOs;
using UserManagement.Application.Implementations;
using UserManagement.Application.Interfaces;
using UserManagement.Domain.Entities;

namespace UserManagement.UnitTests.Application
{
    public class UserManagerTests
    {
        private readonly Mock<IUserRepositoryMock> _userRepositoryMock = new();
        private readonly Mock<IAuthorizationClient> _authorizationClientMock = new();

        [Fact]
        public void CreateUser_ValidUser_ReturnsCreatedUserId()
        {
            // Arrange
            var newUser = new UserDTO
            {
                Id = 5,
                Name = "TestUser",
                RoleIds = new int[] { 1, 2 }
            };

            _userRepositoryMock.Setup(x => x.GetUser(It.IsAny<int>())).ReturnsAsync((User)null);
            _userRepositoryMock.Setup(x => x.CreateUser(It.IsAny<User>())).ReturnsAsync(newUser.Id);
            _authorizationClientMock.Setup(x => x.GetRolesAuthorization(It.IsAny<int[]>())).ReturnsAsync("Authorized");

            UserManager userManager = new(_userRepositoryMock.Object, _authorizationClientMock.Object);

            // Act
            var result = userManager.CreateUser(newUser).Result;

            // Assert
            Assert.Equal(newUser.Id, result);
        }

        [Fact]
        public void CreateUser_ValidUserWithExistingId_NoUserCreated()
        {
            // Arrange
            var newUser = new UserDTO
            {
                Id = 5,
                Name = "TestUser",
                RoleIds = new int[] { 1, 2 }
            };

            var existingUser = new User { Id = 5 };

            _userRepositoryMock.Setup(x => x.GetUser(It.IsAny<int>())).ReturnsAsync(existingUser);
            _authorizationClientMock.Setup(x => x.GetRolesAuthorization(It.IsAny<int[]>())).ReturnsAsync("Authorized");

            UserManager userManager = new(_userRepositoryMock.Object, _authorizationClientMock.Object);

            // Act
            var result = userManager.CreateUser(newUser).Result;

            // Assert
            Assert.Equal(-1, result);
        }

        [Fact]
        public void CreateUser_InvalidUserWithNonExistingRoleId_NoUserCreated()
        {
            // Arrange
            var newUser = new UserDTO
            {
                Id = 5,
                Name = "TestUser",
                RoleIds = new int[] { 1, 5 }
            };

            _userRepositoryMock.Setup(x => x.GetUser(It.IsAny<int>())).ReturnsAsync((User)null);
            _authorizationClientMock.Setup(x => x.GetRolesAuthorization(It.IsAny<int[]>())).ReturnsAsync("Unauthorized");

            UserManager userManager = new(_userRepositoryMock.Object, _authorizationClientMock.Object);

            // Act
            var result = userManager.CreateUser(newUser).Result;

            // Assert
            Assert.Equal(-1, result);
        }
    }
}