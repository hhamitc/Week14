using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace _02_JwtPractice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet("public")]
        public IActionResult PublicEndpoint()
        {
            return Ok(new { message = "Bu endpoint herkese açık!" });
        }

        [HttpGet("test")]
        [Authorize]
        public IActionResult ProtectedEndpoint()
        {
            var userEmail = User.Claims.FirstOrDefault(c => c.Type == System.Security.Claims.ClaimTypes.Email)?.Value;
            
            return Ok(new { 
                message = "Bu korumalı endpoint'e erişim sağladınız!", 
                userEmail = userEmail 
            });
        }
    }
} 