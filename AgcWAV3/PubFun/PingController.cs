using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class PingController : ControllerBase
{
    [AllowAnonymous]
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("✔ WebAPI 正常运行！");
    }
}
