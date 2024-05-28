﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Task3_AuthenticationAPI.Helpers;

namespace Task3_AuthenticationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        [HttpGet("player-area")]
        [Authorize(Roles = AppRoles.Player)]
        public IActionResult GetPlayerArea()
        {
            return Ok("Welcome Player!");
        }

        [HttpGet("admin-area")]
        [Authorize(Roles = AppRoles.Admin)]
        public IActionResult GetAdminArea()
        {
            return Ok("Welcome Admin!");
        }
    }
}
