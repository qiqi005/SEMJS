namespace SEJMS.Models
{
    public class User
    {
        public int UserId { get; set; }

        public string Username { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;

        public string Role { get; set; } = string.Empty;
        public string? AvatarPath { get; set; }
        public bool IsActive { get; set; } = true;
    }
}