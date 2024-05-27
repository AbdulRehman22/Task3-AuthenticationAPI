using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Task3_AuthenticationAPI.DTOs;
using Task3_AuthenticationAPI.Helpers;
using Task3_AuthenticationAPI.Model;

namespace Task3_AuthenticationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly JWTTokenSettingsManager _tokenSettings;

        public AuthController(IOptions<JWTTokenSettingsManager> tokenSettings) 
        {
            _tokenSettings = tokenSettings.Value;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginResquest loginRequest)
        {
            var user = UserStore.Users.SingleOrDefault(u => u.Username == loginRequest.Username && u.Password == loginRequest.Password);

            if (user == null)
            {
                return Unauthorized();
            }

            var tokenString = TokenGenerator.GenerateToken(_tokenSettings.Key, _tokenSettings.Audience, _tokenSettings.Issuer, user);
          
            return Ok(new LoginResponse
            {
                Token = tokenString,
                Roles = user.Roles,
                Regions = user.Regions
            });
        }
    }
}
