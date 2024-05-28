using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Task3_AuthenticationAPI.DTOs;
using Task3_AuthenticationAPI.Helpers;
using Task3_AuthenticationAPI.Interfaces;

namespace Task3_AuthenticationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly JWTTokenSettingsManager _tokenSettings;
        private readonly IUser _user;

        public AuthController(IOptions<JWTTokenSettingsManager> tokenSettings, IUser user) 
        {
            _tokenSettings = tokenSettings.Value;
            _user = user;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginResquest loginRequest)
        {
            try
            {
                var user = _user.Authenticate(loginRequest);

                if (user == null)
                {
                return Unauthorized(new { error = "Incorrect username or password" } );
                }

                var tokenString = TokenGenerator.GenerateToken(_tokenSettings.Key, _tokenSettings.Audience, _tokenSettings.Issuer, user);

                return Ok(new LoginResponse
                {
                    Token = tokenString,
                    Roles = user.Roles,
                    Regions = user.Regions
                });
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }
    }
}
