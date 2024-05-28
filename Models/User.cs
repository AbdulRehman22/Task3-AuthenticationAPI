﻿namespace Task3_AuthenticationAPI.Models
{
    public class User
    {
        public required string Username { get; set; }
        public required string Password { get; set; }
        public required string Role { get; set; }
        public required string[] Regions { get; set; }
    }
}
