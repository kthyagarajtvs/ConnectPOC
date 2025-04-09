namespace ConnectPOC.DTOs
{
    public class UserRegistrationDto
    {
        public string Id { get; set; } = string.Empty;
        public string UserId { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public string CreatedAt { get; set; } = string.Empty;
        public int CityId { get; set; }
    }
}
