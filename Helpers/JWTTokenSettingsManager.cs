namespace Task3_AuthenticationAPI.Helpers
{
    public class JWTTokenSettingsManager
    {
        public string Issuer { get; set; }
        public string Audience { get; set; }
        public string Key { get; set; }
    }
}
