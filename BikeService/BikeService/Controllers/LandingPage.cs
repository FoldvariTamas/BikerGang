using Microsoft.AspNetCore.Mvc;

namespace BikeService.Controllers;

[ApiController]
[Route("[controller]")]
public class LandingPage : ControllerBase
{
    [HttpGet]
    public IActionResult Welcome()
    {
        return Ok("Welcome to BikeService!");
    }
}