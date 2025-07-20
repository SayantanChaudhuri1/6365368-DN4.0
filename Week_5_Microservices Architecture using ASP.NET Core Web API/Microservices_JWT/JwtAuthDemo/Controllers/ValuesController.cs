using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JwtAuthDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        [HttpGet("public")]
        public IActionResult Public() => Ok("✅ This is a public endpoint.");

        [Authorize]
        [HttpGet("secure")]
        public IActionResult Secure() => Ok($"🔐 Hello {User.Identity?.Name}, this is a protected endpoint.");
    }
}
