[ApiController]
[Route("api/[controller]")]
public class uploadController : ControllerBase
{
    [HttpGet]
    public IActionResult Test() // Return HTTP response
    {
        return Ok("Backend works");
    }
}