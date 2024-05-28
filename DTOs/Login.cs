namespace Task3_AuthenticationAPI.DTOs
{
    public class LoginResquest
    {
        public required string Username { get; set; }
        public required string Password { get; set; }
    }
    public class LoginResponse
    {
        public required string Token { get; set; }
        public required string Role { get; set; }
        public required string[] Regions { get; set; }
    }
}
