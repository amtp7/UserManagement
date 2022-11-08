namespace UserManagement.Application.Interfaces
{
    public interface IAuthorizationClient
    {
        public Task<string> GetRolesAuthorization(int[] roleIds);
    }
}
