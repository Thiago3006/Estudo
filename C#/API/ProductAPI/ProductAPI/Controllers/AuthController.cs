using Microsoft.AspNetCore.Mvc;

namespace ProductAPI.Controllers
{
    [ApiController]
    [Route("api/account")]
    public class AuthController : ControllerBase
    {
        [HttpPost("register")]
        public async Task<ActionResult> Register()
        {           
            return Ok();
        }

        [HttpPost("login")]
        public async Task<ActionResult> Login()
        {
            return Ok();
        }
    }
}
