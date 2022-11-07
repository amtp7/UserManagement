namespace UserManagement.Application.DTOs
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public int[] RoleIds { get; set; }
    }
}
