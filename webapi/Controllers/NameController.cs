using Microsoft.AspNetCore.Mvc;

namespace webapi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class NameController : ControllerBase
{
    [HttpGet]
    public IActionResult GetName()
    {
        return Ok(new { firstName = "Samuel", lastName = "Amponsah" });
    }
}