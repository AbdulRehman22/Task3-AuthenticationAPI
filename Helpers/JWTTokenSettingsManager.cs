namespace Task3_AuthenticationAPI.Helpers
{
    public class JWTTokenSettingsManager
    {
        public required string Issuer { get; set; }
        public required string Audience { get; set; }
        public required string Key { get; set; }
    }
}
