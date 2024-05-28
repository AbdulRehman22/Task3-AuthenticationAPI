using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Task3_AuthenticationAPI.Helpers;

namespace Task3_AuthenticationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        [HttpGet("player-area")]
        [Authorize(Policy = AppRegions.PlayerRegion)]
        public IActionResult GetPlayerArea()
        {
            return Ok(new { message = "Welcome Player!" });
        }

        [HttpGet("admin-area")]
        [Authorize(Policy = AppRegions.AdminRegion)]
        public IActionResult GetAdminArea()
        {
            return Ok(new { message = "Welcome Admin!" });
        }
    }
}
